using KinoPolis.Web.ViewModels.Films;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Services.Data
{
    public interface IFilmsService
    {
        IEnumerable<T> GetAllFilms<T>();

        ByNameViewModel GetFilmByName(string name);

        IEnumerable<T> GetSortedFilms<T>();
    }
}
