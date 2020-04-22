using KinoPolis.Services.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoPolis.Web.Controllers
{
    public class TicketsController : BaseController
    {
        private readonly ITicketsService ticketsService;

        public TicketsController(ITicketsService ticketsService)
        {
            this.ticketsService = ticketsService;
        }

        public IActionResult Reserve(int ticketSeat, int id)
        {
            var ticketId = this.ticketsService.GetTicketId(id, ticketSeat);
            return this.View();
        }
    }
}
