using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ProAPI.Data;
using ProAPI.Models.Entity;
using ProAPI.Repository.IRepository;
using System.Diagnostics;

namespace ProAPI.Repository
{
    public class DibujoRepository : IDibujoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMemoryCache _cache;
        private readonly string DibujoEntityCacheKey = "DibujoEntityCacheKey"; //cambiadmelo lokos
        private readonly int CacheExpirationTime = 3600;
        public DibujoRepository(ApplicationDbContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public async Task<bool> Save()
        {
            var result = await _context.SaveChangesAsync() >= 0;
            if (result)
            {
                ClearCache();
            }
            return result;
        }

        public void ClearCache()
        {
            _cache.Remove(DibujoEntityCacheKey);
        }

        public async Task<ICollection<DibujoEntity>> GetAllAsync()
        {
            if (_cache.TryGetValue(DibujoEntityCacheKey, out ICollection<DibujoEntity> DibujosCached))
                return DibujosCached;

            var dibujosFromDb = await _context.Dibujos.OrderBy(c => c.Name).ToListAsync();
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                  .SetAbsoluteExpiration(TimeSpan.FromSeconds(CacheExpirationTime));

            _cache.Set(DibujoEntityCacheKey, dibujosFromDb, cacheEntryOptions);
            return dibujosFromDb;
        }

        public async Task<DibujoEntity> GetAsync(int id)
        {
            if (_cache.TryGetValue(DibujoEntityCacheKey, out ICollection<DibujoEntity> DibujosCached))
            {
                var DibujoEntity = DibujosCached.FirstOrDefault(c => c.Id == id);
                if (DibujoEntity != null)
                    return DibujoEntity;
            }

            return await _context.Dibujos.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Dibujos.AnyAsync(c => c.Id == id);
        }

        public async Task<bool> CreateAsync(DibujoEntity DibujoEntity)
        {
            _context.Dibujos.Add(DibujoEntity);
            return await Save();
        }

        public async Task<bool> UpdateAsync(DibujoEntity DibujoEntity)
        {
            DibujoEntity.CreatedDate = DateTime.Now;
            _context.Update(DibujoEntity);
            return await Save();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var DibujoEntity = await GetAsync(id);
            if (DibujoEntity == null)
                return false;

            _context.Dibujos.Remove(DibujoEntity);
            return await Save();
        }
    }
}
