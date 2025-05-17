using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SuperShopCet97.Web.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Product")]
        [MaxLength(50, ErrorMessage = "The field {0} must have {1} caracteres at max!")]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Last Purchase")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }

        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://supershopcet-bwe4fag9geawcec7.westeurope-01.azurewebsites.net/images/noimage.png"
            : $"https://supershopcet.blob.core.windows.net/products/{ImageId}";
    }
}
