using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Web.ViewModels.Administration.Cinemas;
using System;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public class CinemasService : ICinemasService
    {
        private readonly IDeletableEntityRepository<Cinema> cinemasRepository;

        public CinemasService(IDeletableEntityRepository<Cinema> cinemasRepository)
        {
            this.cinemasRepository = cinemasRepository;
        }

        public async Task CreateCinemaAsync(CreateInputModel input)
        {
            var cinema = new Cinema()
            {
                Name = input.Name,
                Address = input.Address,
            };
            await this.cinemasRepository.AddAsync(cinema);
            await this.cinemasRepository.SaveChangesAsync();
        }
    }
}
