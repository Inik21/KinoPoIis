using KinoPolis.Data;
using KinoPolis.Data.Models;
using KinoPolis.Data.Repositories;
using KinoPolis.Web.ViewModels.Administration.Films;
using KinoPolis.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KinoPolis.Services.Data.Tests
{
    public class FilmsServiceTests
    {
        private DbContextOptionsBuilder<ApplicationDbContext> options;
        private EfDeletableEntityRepository<Film> filmsRepository;
        private FilmsService service;

        public FilmsServiceTests()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("Film");
            this.filmsRepository = new EfDeletableEntityRepository<Film>(new ApplicationDbContext(this.options.Options));
            this.service = new FilmsService(this.filmsRepository);
        }

        [Fact]
        public async Task TestCreateFilmAsync()
        {
            var input = new CreateImputModel()
            {
                Name = "Film1",
                Category = "action",
                Country = "USA",
                Description = "very good film",
                Lenght = 120,
                Year = 2020,
                ImgUrl = "random url",
            };
            await this.service.CreateFilmAsync(input);
            Assert.True(this.filmsRepository.All().Any(x => x.Name == "Film1"));
        }

        [Fact]
        public async Task TestDeleteFilmAsync()
        {
            var film = new Film() { Name = "Film2" };
            await this.filmsRepository.AddAsync(film);
            await this.filmsRepository.SaveChangesAsync();
            await this.service.DeleteFilmAsync("Film2");
            Assert.False(this.filmsRepository.All().Any(x => x.Name == "Film2"));
        }

        [Fact]
        public async Task TestGetAllFilms()
        {
            var filmvm1 = new IndexFilmViewModel { Name = "film1", Category = "action", Description = "Cool", ImgUrl = "rendom"};
            var filmvm2 = new IndexFilmViewModel { Name = "film2", Category = "drama", Description = "boring", ImgUrl = "drugrandom" };
            var list = new List<IndexFilmViewModel>();
            list.Add(filmvm1);
            list.Add(filmvm2);
            var film1 = new Film { Name = "film1" , Category = "action", Description = "Cool", ImgUrl = "rendom" };
            var film2 = new Film { Name = "film2", Category = "drama", Description = "boring", ImgUrl = "drugrandom" };
            await this.filmsRepository.AddAsync(film1);
            await this.filmsRepository.AddAsync(film2);
            await this.filmsRepository.SaveChangesAsync();
            var filmList = this.service.GetAllFilms<IndexFilmViewModel>();
            Assert.Equal(list, filmList);
        }
    }
}
