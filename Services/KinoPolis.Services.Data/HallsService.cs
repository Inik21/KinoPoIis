using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Web.ViewModels.Administration.Halls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public class HallsService : IHallsService
    {
        private readonly IDeletableEntityRepository<Hall> hallsRepository;
        private readonly IDeletableEntityRepository<Cinema> cinemasRepository;

        public HallsService(IDeletableEntityRepository<Hall> hallsRepository, IDeletableEntityRepository<Cinema> cinemasRepository)
        {
            this.hallsRepository = hallsRepository;
            this.cinemasRepository = cinemasRepository;
        }

        public async Task CreateHallAsync(CreateInputModel input)
        {
            var cinema = this.cinemasRepository.All().FirstOrDefault(x => x.Name == input.CinemaName);
            var hall = new Hall
            {
                NumberofHall = input.NumberOfHall,
                Rows = input.Rows,
                SeatsPerRow = input.SeatsPerRow,
                Cinema = cinema,
            };
            await this.hallsRepository.AddAsync(hall);
            await this.hallsRepository.SaveChangesAsync();
        }

        public bool ValidateHallExist(string cinemaName, int numberOfHall)
        {
            var cinema = this.cinemasRepository.All().FirstOrDefault(x => x.Name == cinemaName);
            return this.hallsRepository.All().Any(x => x.CinemaId == cinema.Id && x.NumberofHall == numberOfHall);
        }
    }
}
