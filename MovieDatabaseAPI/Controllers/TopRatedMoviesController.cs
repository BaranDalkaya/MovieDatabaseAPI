using Microsoft.AspNetCore.Mvc;
using MovieDatabaseAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MovieDatabaseAPI.Models.Class;

namespace MovieDatabaseAPI.Controllers
{
    public class TopRatedMoviesController : Controller
    {
        public  static List<Root> roots = new List<Root>();

        public IActionResult Index()
        {
            var listOfMovies = GetData<ResponseTopRatedMovies>();
            return View(listOfMovies.Result);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Movie = roots.FirstOrDefault(m => m.id == id);
            if (Movie == null)
            {
                return NotFound();
            }

            return View(Movie);
        }


        public async Task<ResponseTopRatedMovies> GetData<T>()
        {
            
            var responseObj = new ResponseTopRatedMovies();
            var apiKey = "6bdd58aefaf7fe620ff0868a44117871";
            var url = $"https://api.themoviedb.org/3/movie/top_rated?api_key={apiKey}&language=en-US&page=1";

            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync();
                        var ResponseObject = JsonConvert.DeserializeObject<ResponseTopRatedMovies>(ResponseString);
                        responseObj.Results = ResponseObject.Results;

                        foreach (Result result in ResponseObject.Results)
                        {
                            var Movie = new Root()
                            {
                                id = result.Id,
                                Title = result.Title,
                                Description = result.Description,
                                ReleaseDate = result.ReleaseDate,
                                Rating = result.Rating
                            };
                            
                            roots.Add(Movie);
                        }
                    }
                    return responseObj;
                }
            }
            catch (Exception)
            {
                return responseObj;
            }
        }
    }
}
