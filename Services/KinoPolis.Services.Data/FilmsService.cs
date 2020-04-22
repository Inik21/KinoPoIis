using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using KinoPolis.Web.ViewModels.Films;
using KinoPolis.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KinoPolis.Services.Data
{
    public class FilmsService : IFilmsService
    {
        private readonly IDeletableEntityRepository<Film> filmsRepository;

        public FilmsService(IDeletableEntityRepository<Film> filmsRepository)
        {
            this.filmsRepository = filmsRepository;
        }

        public IEnumerable<T> GetAllFilms<T>()
        {
            var query = this.filmsRepository.All().To<T>().ToList();
            return query;
        }

        public ByNameViewModel GetFilmByName(string name)
        {
            var realName = name.Replace('-', ' ');
            var film = this.filmsRepository.All().To<ByNameViewModel>().FirstOrDefault(x => x.Name == realName);
            return film;
        }

        public IEnumerable<T> GetSortedFilms<T>()
        {
            var query = this.filmsRepository.All().OrderBy(x => x.Name).To<T>().ToList();
            return query;
        }
    }
}
