using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Urun Adi")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [Range(0, 100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
    }
}