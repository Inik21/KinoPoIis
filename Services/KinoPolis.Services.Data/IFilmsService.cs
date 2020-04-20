using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Services.Data
{
    public interface IFilmsService
    {
        public IEnumerable<T> GetAllFilms<T>();
    }
}
