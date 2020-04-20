using KinoPolis.Services.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoPolis.Web.Controllers
{
    public class FilmsController : BaseController
    {
        private readonly IFilmsService filmsService;

        public FilmsController(IFilmsService filmsService)
        {
            this.filmsService = filmsService;
        }

        public IActionResult ByName(string name)
        {
            var film = this.filmsService.GetFilmByName(name);

            return this.View();
        }
    }
}
