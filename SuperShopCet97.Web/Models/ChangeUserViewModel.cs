﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SuperShopCet97.Web.Models
{
    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "The field {0} only can contain {1} characters lenght.")]
        public string Address { get; set; }

        [MaxLength(20, ErrorMessage = "The field {0} only can contain {1} characters lenght.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "City")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a city.")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }

        [Display(Name = "Country")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a city.")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
