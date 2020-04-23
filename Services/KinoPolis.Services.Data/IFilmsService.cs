using KinoPolis.Web.ViewModels.Administration.Films;
using KinoPolis.Web.ViewModels.Films;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public interface IFilmsService
    {
        IEnumerable<T> GetAllFilms<T>();

        ByNameViewModel GetFilmByName(string name);

        IEnumerable<T> GetSortedFilms<T>();

        Task CreateFilmAsync(CreateImputModel input);

        Task DeleteFilmAsync(string name);
    }
}
