﻿namespace KinoPolis.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using KinoPolis.Services.Data;
    using KinoPolis.Web.ViewModels.Films;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class FilmsController : BaseController
    {
        private readonly IFilmsService filmsService;

        public FilmsController(IFilmsService filmsService)
        {
            this.filmsService = filmsService;
        }

        [Authorize]
        public IActionResult ByName(string name)
        {
            var viewModel = this.filmsService.GetFilmByName(name);
            return this.View(viewModel);
        }
    }
}
