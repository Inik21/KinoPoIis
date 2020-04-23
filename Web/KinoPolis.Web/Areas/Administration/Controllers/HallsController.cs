using KinoPolis.Common;
using KinoPolis.Services.Data;
using KinoPolis.Web.ViewModels.Administration.Halls;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoPolis.Web.Areas.Administration.Controllers
{
    public class HallsController : AdministrationController
    {
        private readonly IHallsService hallsService;
        private readonly ICinemasService cinemasService;

        public HallsController(IHallsService hallsService, ICinemasService cinemasService)
        {
            this.hallsService = hallsService;
            this.cinemasService = cinemasService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(CreateInputModel input)
        {
            this.ViewData["ErrorMessage"] = null;
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            if (!this.cinemasService.ValidateCinemaName(input.CinemaName))
            {
                this.ViewData["ErrorMessage"] = "The name of the Cinema is not valid";
                return this.View(input);
            }

            if (this.hallsService.ValidateHallExist(input.CinemaName, input.NumberOfHall))
            {
                this.ViewData["ErrorMessage"] = "The hall already exists";
                return this.View(input);
            }

            await this.hallsService.CreateHallAsync(input);
            return this.Redirect("/");
        }
    }
}
