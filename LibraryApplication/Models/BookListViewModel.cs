using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class BookListViewModel
    {

        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(130)]
        public string Title { get; set; }
        public string Publisher { get; set; }
        public virtual Contry Country { get; set; }

        [Display(Name = "Publisher Year")]
        public int StartYear { get; set; }

        [Display(Name = "End Year")]
        public int EndYear { get; set; }
    }
}