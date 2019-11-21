using Assessment7Prep.Models;
using System.Threading.Tasks;

namespace Assessment7Prep.Services
{
    public interface IFilmService
    {
        Task<StarWarsFilmsViewModel> GetAllFilms();
    }
}
