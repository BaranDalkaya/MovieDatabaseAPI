using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieDatabaseAPI.Models.Class
{
    public class Result
    {
        public string poster_path { get; set; }
        public bool adult { get; set; }
        [JsonProperty("overview")]
        public string Description { get; set; }
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
        public List<int> genre_ids { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        public string original_title { get; set; }
        public string original_language { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        public string backdrop_path { get; set; }
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        [JsonProperty("vote_average")]
        public double Rating { get; set; }
    }
}
