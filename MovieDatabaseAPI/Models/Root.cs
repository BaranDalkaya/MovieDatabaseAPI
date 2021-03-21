using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MovieDatabaseAPI.Models.Class;
using Newtonsoft.Json;

namespace MovieDatabaseAPI.Models
{
    public class Root
    {
        // Properties taked from JSON -> C# converter. I have only used certain properties for this application hence have not maintained the rest.

        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public object belongs_to_collection { get; set; }
        public int budget { get; set; }
        public List<Genre> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        [JsonProperty("overview")]
        public string Description { get; set; }
        public double popularity { get; set; }
        public object poster_path { get; set; }
        public List<ProductionCompany> production_companies { get; set; }
        public List<ProductionCountry> production_countries { get; set; }
        [JsonProperty("release_date")]
        [DisplayName("Release Date")]
        public string ReleaseDate { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }
        public List<SpokenLanguage> spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        public bool video { get; set; }
        [JsonProperty("vote_average")]
        public double Rating { get; set; }
        public int vote_count { get; set; }
    }
}
