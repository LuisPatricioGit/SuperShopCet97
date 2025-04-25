using System;
using System.ComponentModel.DataAnnotations;

namespace SuperShopCet97.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Product")]
        [MaxLength(50, ErrorMessage = "The field {0} must have {1} caracteres at max!")]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }
}
