using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using System;
using System.Linq;

namespace KinoPolis.Services.Data
{
    public class TicketsService : ITicketsService
    {
        private readonly IDeletableEntityRepository<Ticket> ticketRepository;

        public TicketsService(IDeletableEntityRepository<Ticket> ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public int GetTicketId(int projectionId, int seat)
        {
            var ticket = this.ticketRepository.All().FirstOrDefault(x => x.ProjectionId == projectionId && x.Seat == seat);
            return ticket.Id;
        }
    }
}
