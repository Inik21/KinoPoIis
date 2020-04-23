
using KinoPolis.Common;
using KinoPolis.Services.Data;
using KinoPolis.Web.ViewModels.Administration.Films;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoPolis.Web.Areas.Administration.Controllers
{
    public class FilmsController : AdministrationController
    {
        private readonly IFilmsService filmsService;

        public FilmsController(IFilmsService filmsService)
        {
            this.filmsService = filmsService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        [HttpPost]
        public async Task<IActionResult> Create(CreateImputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.filmsService.CreateFilmAsync(input);
            return this.Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Delete(string id)
        {
            var name = id.Replace('-', ' ');
            await this.filmsService.DeleteFilmAsync(name);
            return this.Redirect("/");
        }
    }
}
