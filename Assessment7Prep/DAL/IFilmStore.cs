using System.Threading.Tasks;

namespace Assessment7Prep.DAL
{
    public interface IFilmStore
    {
        Task<FilmResultModel> GetAllFilms();
    }
}
