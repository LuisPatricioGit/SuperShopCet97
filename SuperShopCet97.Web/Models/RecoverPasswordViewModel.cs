using System.ComponentModel.DataAnnotations;

namespace SuperShopCet97.Web.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
