namespace KinoPolis.Web.Controllers
{
    using KinoPolis.Services.Data;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProjectionsController : BaseController
    {
        private readonly IProjectionsService projectionsService;

        public ProjectionsController(IProjectionsService projectionsService)
        {
            this.projectionsService = projectionsService;
        }

        [Authorize]
        public IActionResult ById(int id)
        {
            var viewModel = this.projectionsService.GetProjectionById(id);
            return this.View(viewModel);
        }
    }
}
