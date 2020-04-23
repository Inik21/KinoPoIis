using KinoPolis.Data;
using KinoPolis.Data.Models;
using KinoPolis.Data.Repositories;
using KinoPolis.Web.ViewModels.Administration.Halls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KinoPolis.Services.Data.Tests
{
    public class HallsServiceTests
    {
        private HallsService service;
        private DbContextOptionsBuilder<ApplicationDbContext> options;
        private EfDeletableEntityRepository<Hall> hallsRepository;
        private EfDeletableEntityRepository<Cinema> cinemasRepository;

        public HallsServiceTests()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("Hall");
            this.hallsRepository = new EfDeletableEntityRepository<Hall>(new ApplicationDbContext(this.options.Options));
            this.cinemasRepository = new EfDeletableEntityRepository<Cinema>(new ApplicationDbContext(this.options.Options));
            this.service = new HallsService(this.hallsRepository, this.cinemasRepository);
        }

        [Fact]
        public async Task TestCreateHallAsync()
        {
            var input = new CreateInputModel()
            {
                 CinemaName = "Kino1",
                 NumberOfHall = 1,
                 Rows = 3,
                 SeatsPerRow = 3,
            };
            await this.service.CreateHallAsync(input);
            Assert.True(this.hallsRepository.All().Any(x => x.NumberofHall == input.NumberOfHall));
        }

        [Fact]
        public async Task TestValidateHallExist()
        {
            var cinema = new Cinema { Id = 1, Name = "kino1" };
            await this.cinemasRepository.AddAsync(cinema);
            await this.cinemasRepository.SaveChangesAsync();
            var hall = new Hall() { NumberofHall = 1, CinemaId = 1 };
            await this.hallsRepository.AddAsync(hall);
            await this.hallsRepository.SaveChangesAsync();
            Assert.True(this.service.ValidateHallExist("kino1", 1));
        }
    }
}
