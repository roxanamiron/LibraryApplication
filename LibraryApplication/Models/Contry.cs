using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class Contry
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}