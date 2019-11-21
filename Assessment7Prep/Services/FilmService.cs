using Assessment7Prep.DAL;
using Assessment7Prep.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment7Prep.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmStore _filmStore;

        public FilmService(IFilmStore filmStore)
        {
            _filmStore = filmStore ?? throw new ArgumentNullException(nameof(filmStore));
        }

        public async Task<StarWarsFilmsViewModel> GetAllFilms()
        {
            var result = await _filmStore.GetAllFilms();

            var filmViewModel = new StarWarsFilmsViewModel
            {
                Films = result.Results.Select(film => 
                    new Film { 
                        Title = film.Title, 
                        Crawl = film.Opening_Crawl, 
                        Director = film.Director
                    })
            };

            return filmViewModel;
        }
    }
}
