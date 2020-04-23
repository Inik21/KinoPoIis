using KinoPolis.Data;
using KinoPolis.Data.Models;
using KinoPolis.Data.Repositories;
using KinoPolis.Web.ViewModels.Administration.Projections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KinoPolis.Services.Data.Tests
{
    public class ProjectionsServiceTests
    {
        private DbContextOptionsBuilder<ApplicationDbContext> options;
        private EfDeletableEntityRepository<Hall> hallsRepository;
        private EfDeletableEntityRepository<Cinema> cinemasRepository;
        private EfDeletableEntityRepository<Projection> projectionsRepository;
        private EfDeletableEntityRepository<Film> filmsRepository;
        private ProjectionsService service;

        public ProjectionsServiceTests()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("Projection");
            this.hallsRepository = new EfDeletableEntityRepository<Hall>(new ApplicationDbContext(this.options.Options));
            this.cinemasRepository = new EfDeletableEntityRepository<Cinema>(new ApplicationDbContext(this.options.Options));
            this.projectionsRepository = new EfDeletableEntityRepository<Projection>(new ApplicationDbContext(this.options.Options));
            this.filmsRepository = new EfDeletableEntityRepository<Film>(new ApplicationDbContext(this.options.Options));
            this.service = new ProjectionsService(this.projectionsRepository, this.cinemasRepository, this.hallsRepository, this.filmsRepository);
        }

       //[Fact]
       //public async Task TestCreateProjectionAsync()
       //{
       //    var hall = new Hall()
       //    {
       //        
       //        NumberofHall = 10013,
       //        Rows = 3,
       //        SeatsPerRow = 3,
       //    };
       //    await this.hallsRepository.AddAsync(hall);
       //    await this.hallsRepository.SaveChangesAsync();
       //    var input = new CreateImputModel()
       //    {
       //        CinemaName = "kino1",
       //        NameOfFilm = "film1",
       //        NumberOfHall = 10013,
       //        Price = 100,
       //        Time = DateTime.UtcNow,
       //    };
       //    await this.service.CreateProjectionAsync(input);
       //    Assert.True(this.projectionsRepository.All().Any(x => x.Price == input.Price));
       //}
    }
}
