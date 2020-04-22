using KinoPolis.Services.Data;
using KinoPolis.Web.ViewModels.Tickets;
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
            var viewModel = this.ticketsService.GetViewModel(ticketId);
            return this.View(viewModel);
        }

        public async Task<IActionResult> PostReserve(ReserveViewModel input)
        {
            await this.ticketsService.ReserveTicketAsync(input);
            return this.Redirect("/");
        }
    }
}
