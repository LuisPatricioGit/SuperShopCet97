using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SuperShopCet97.Web.Data.Entities;

namespace SuperShopCet97.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
