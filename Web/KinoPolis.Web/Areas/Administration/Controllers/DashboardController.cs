namespace KinoPolis.Web.Areas.Administration.Controllers
{
    using KinoPolis.Common;
    using KinoPolis.Services.Data;
    using KinoPolis.Web.ViewModels.Administration.Dashboard;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly IFilmsService filmsService;

        public DashboardController(IFilmsService filmsService)
        {
            this.filmsService = filmsService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var films = this.filmsService.GetAllFilms<IndexFilmViewModel>();
            viewModel.Films = films;
            return this.View(viewModel);
        }
    }
}
