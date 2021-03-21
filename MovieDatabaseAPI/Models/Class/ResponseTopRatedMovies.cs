using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieDatabaseAPI.Models.Class
{
    public class ResponseTopRatedMovies
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("results")]
        public List<Result> Results { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
