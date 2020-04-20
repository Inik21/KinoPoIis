using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
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

        public Film GetFilmByName(string name)
        {
            var film = this.filmsRepository.All().FirstOrDefault(x => x.Name == name);
            return film;
        }
    }
}
