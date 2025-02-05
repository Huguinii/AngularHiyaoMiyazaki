﻿using System.ComponentModel.DataAnnotations;

namespace ProAPI.Models.DTOs.CategoryDto
{

    public class CategoryDto : CreateCategoryDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
