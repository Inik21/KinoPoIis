using KinoPolis.Services.Data;
using KinoPolis.Web.ViewModels.Tickets;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public IActionResult Reserve(int ticketSeat, int id)
        {
            var ticketId = this.ticketsService.GetTicketId(id, ticketSeat);
            var viewModel = this.ticketsService.GetViewModel(ticketId);
            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> PostReserve(ReserveViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Reserve", input);
            }
            else
            {
                await this.ticketsService.ReserveTicketAsync(input);
                return this.RedirectToAction("ThankYouForReserving");
            }

        }

        [Authorize]
        public IActionResult ThankYouForReserving()
        {
            return this.View();
        }
    }
}
