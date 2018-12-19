using LibraryApplication.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Repository.Entities
{
    public class Counter
    {
        [JsonProperty("totalItems")]
        public int totalItems { get; set; }

        [JsonProperty("endIndex")]
        public int endIndex { get; set; }

        [JsonProperty("startIndex")]
        public int startIndex { get; set; }

        [JsonProperty("itemsPerPage")]
        public int itemsPerPage { get; set; }

        [JsonProperty("items")]
        public List<Book> books { get; set; } 
    }
}