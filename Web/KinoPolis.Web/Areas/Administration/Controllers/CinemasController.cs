namespace KinoPolis.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using KinoPolis.Common;
    using KinoPolis.Services.Data;
    using KinoPolis.Web.ViewModels.Administration.Cinemas;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class CinemasController : AdministrationController
    {
        private readonly ICinemasService cinemasService;

        public CinemasController(ICinemasService cinemasService)
        {
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
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.cinemasService.CreateCinemaAsync(input);
            return this.Redirect("/");
        }
    }
}
