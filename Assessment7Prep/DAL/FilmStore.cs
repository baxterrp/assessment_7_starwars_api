using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assessment7Prep.DAL
{
    public class FilmStore : IFilmStore
    {
        public async Task<FilmResultModel> GetAllFilms()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://swapi.co/") })
            {
                var resultGenerally = await httpClient.GetStringAsync("api/films/");
                return JsonConvert.DeserializeObject<FilmResultModel>(resultGenerally);
            }
        }
    }
}
