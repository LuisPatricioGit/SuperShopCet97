using System.ComponentModel.DataAnnotations;
using System;

namespace SuperShopCet97.Web.Models
{
    public class DeliveryViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Delivery Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DeliveryDate { get; set; }
    }
}
