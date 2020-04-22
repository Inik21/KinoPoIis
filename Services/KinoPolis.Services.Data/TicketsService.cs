using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Web.ViewModels.Tickets;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace KinoPolis.Services.Data
{
    public class TicketsService : ITicketsService
    {
        private readonly IDeletableEntityRepository<Ticket> ticketsRepository;

        public TicketsService(IDeletableEntityRepository<Ticket> ticketsRepository)
        {
            this.ticketsRepository = ticketsRepository;
        }

        public int GetTicketId(int projectionId, int seat)
        {
            var ticket = this.ticketsRepository.All().FirstOrDefault(x => x.ProjectionId == projectionId && x.Seat == seat);
            return ticket.Id;
        }

        public ReserveViewModel GetViewModel(int ticketId)
        {
            var reserveViewModel = new ReserveViewModel
            {
                Id = ticketId,
            };
            return reserveViewModel;
        }

        public async Task ReserveTicketAsync(ReserveViewModel input)
        {
            var ticket = this.ticketsRepository.All().FirstOrDefault(x => x.Id == input.Id);
            ticket.FirstNameOfBuyer = input.FirstNameOfBuyer;
            ticket.SecondNameOfBuyer = input.SecondNameOfBuyer;
            ticket.IsReserved = true;
            this.ticketsRepository.Update(ticket);
            await this.ticketsRepository.SaveChangesAsync();
        }
    }
}
