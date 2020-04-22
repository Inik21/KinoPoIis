using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoPolis.Web.Controllers
{
    public class TicketsController : BaseController
    {
        public IActionResult ById(int ticketSeat, int id)
        {
            return this.View();
        }
    }
}
