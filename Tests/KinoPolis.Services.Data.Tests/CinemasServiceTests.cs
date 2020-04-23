using KinoPolis.Data;
using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Data.Repositories;
using KinoPolis.Web.ViewModels.Administration.Cinemas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KinoPolis.Services.Data.Tests
{
    public class CinemasServiceTests
    {
        private DbContextOptionsBuilder<ApplicationDbContext> options;
        private EfDeletableEntityRepository<Cinema> cinemasRepository;
        private CinemasService service;

        public CinemasServiceTests()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("Cinema");
            this.cinemasRepository = new EfDeletableEntityRepository<Cinema>(new ApplicationDbContext(this.options.Options));
            this.service = new CinemasService(this.cinemasRepository);
        }

        [Fact]
        public async Task TestCreateCinemaAsync()
        {

            var input = new CreateInputModel()
            {
                Name = "Kino1",
                Address = "Kv OvchaKupel",
            };
            await this.service.CreateCinemaAsync(input);
            Assert.True(this.cinemasRepository.All().Any(x => x.Name == "Kino1"));
        }

        [Fact]
        public async Task TestValidateCinemaName()
        {
            await this.cinemasRepository.AddAsync(new Cinema { Name = "Kino2" });
            await this.cinemasRepository.SaveChangesAsync();
            Assert.True(this.service.ValidateCinemaName("Kino2"));
        }
    }
}
