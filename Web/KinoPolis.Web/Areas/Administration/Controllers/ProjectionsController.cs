namespace KinoPolis.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using KinoPolis.Common;
    using KinoPolis.Services.Data;
    using KinoPolis.Web.ViewModels.Administration.Projections;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ProjectionsController : AdministrationController
    {
        private readonly IProjectionsService projectionsService;

        public ProjectionsController(IProjectionsService projectionsService)
        {
            this.projectionsService = projectionsService;
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.projectionsService.DeleteProjectionByIdAsync(id);
            return this.Redirect("/Administration/Dashboard/Index");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create(string id)
        {
            var viewModel = new CreateImputModel()
            {
                NameOfFilm = id,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(CreateImputModel input)
        {
            this.ViewData["ErrorMessage"] = null;
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            if (!this.projectionsService.ValidateCinemaName(input.CinemaName))
            {
                this.ViewData["ErrorMessage"] = "The name of the Cinema is not valid";
                return this.View(input);
            }

            if (!this.projectionsService.ValidateHallInCinema(input.CinemaName, input.NumberOfHall))
            {
                this.ViewData["ErrorMessage"] = "There isn't a hall with this number";
                return this.View(input);
            }

            await this.projectionsService.CreateProjectionAsync(input);
            return this.Redirect("/");
        }
    }
}
