using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using KinoPolis.Web.ViewModels.Administration.Projections;
using KinoPolis.Web.ViewModels.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public class ProjectionsService : IProjectionsService
    {
        private readonly IDeletableEntityRepository<Projection> projectionsRepository;
        private readonly IDeletableEntityRepository<Cinema> cinemasRepository;
        private readonly IDeletableEntityRepository<Hall> hallsRepository;
        private readonly IDeletableEntityRepository<Film> filmsRepository;

        public ProjectionsService(IDeletableEntityRepository<Projection> projectionsRepository, IDeletableEntityRepository<Cinema> cinemasRepository, IDeletableEntityRepository<Hall> hallsRepository, IDeletableEntityRepository<Film> filmsRepository)
        {
            this.projectionsRepository = projectionsRepository;
            this.cinemasRepository = cinemasRepository;
            this.hallsRepository = hallsRepository;
            this.filmsRepository = filmsRepository;
        }

        public async Task CreateProjectionAsync(CreateImputModel input)
        {
            var film = this.filmsRepository.All().FirstOrDefault(x => x.Name == input.NameOfFilm);
            var cinema = this.cinemasRepository.All().FirstOrDefault(x => x.Name == input.CinemaName);
            var hall = this.hallsRepository.All().FirstOrDefault(x => x.NumberofHall == input.NumberOfHall);
            var tickets = new List<Ticket>();
            for (int i = hall.Rows; i >= 1; i--)
            {
                for (int l = hall.SeatsPerRow; l >= 1; l--)
                {
                    tickets.Add(new Ticket
                    {
                        Row = i,
                        Seat = ((i - 1) * hall.SeatsPerRow) + l,
                        IsReserved = false,
                    });
                }
            }

            var projection = new Projection
            {
                Price = input.Price,
                Time = input.Time,
                Film = film,
                Cinema = cinema,
                Hall = hall,
                Tickets = tickets,
            };

            await this.projectionsRepository.AddAsync(projection);
            await this.projectionsRepository.SaveChangesAsync();
        }

        public async Task DeleteProjectionByIdAsync(int id)
        {
            var projection = this.projectionsRepository.All().FirstOrDefault(x => x.Id == id);
            this.projectionsRepository.Delete(projection);
            await this.projectionsRepository.SaveChangesAsync();
        }

        public ByIdViewModel GetProjectionById(int id)
        {
            var byIdViewModel = this.projectionsRepository.All().To<ByIdViewModel>().FirstOrDefault(x => x.Id == id);
            return byIdViewModel;
        }

        public bool ValidateCinemaName(string cinemaName)
        {
            return this.cinemasRepository.All().Any(x => x.Name == cinemaName);
        }

        public bool ValidateHallInCinema(string cinemaName, int numberOfHall)
        {
            var cinema = this.cinemasRepository.All().FirstOrDefault(x => x.Name == cinemaName);

            return this.hallsRepository.All().Any(x => x.NumberofHall == numberOfHall && x.CinemaId == cinema.Id);
        }
    }
}
