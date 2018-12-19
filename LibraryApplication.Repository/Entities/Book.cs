using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace LibraryApplication.Domain.Entities
{
    
    public class Book : BaseEntity
    {
        [Key]
        public int BookId { get; set; }


        [JsonProperty("id")]
        public string ExternalId { get; set; }

        [JsonProperty("title")]
        [Required]
        [MaxLength(130)]
        public string Title { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("country")]
        public virtual string Country { get; set; }

        [JsonProperty("start year")]
        [Display(Name = "Publisher Year")]
        public int StartYear { get; set; }

       [JsonProperty("end year")]
        [Display(Name = "End Year")]
        public int EndYear { get; set; }

        //public ICollection<BooksReviews> Reviews { get; set; }
    }
}