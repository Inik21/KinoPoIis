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

        Web.ViewModels.Films.ByNameViewModel GetFilmByName(string name);

        Web.ViewModels.Administration.Films.ByNameViewModel GetFilmByNameAdmin(string name);

        IEnumerable<T> GetSortedFilms<T>();

        Task CreateFilmAsync(CreateImputModel input);

        Task DeleteFilmAsync(string name);
    }
}
