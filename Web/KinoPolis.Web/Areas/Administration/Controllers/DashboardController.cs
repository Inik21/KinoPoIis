namespace KinoPolis.Web.Areas.Administration.Controllers
{
    using KinoPolis.Services.Data;
    using KinoPolis.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly IFilmsService filmsService;

        public DashboardController(IFilmsService filmsService)
        {
            this.filmsService = filmsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var films = this.filmsService.GetAllFilms<IndexFilmViewModel>();
            viewModel.Films = films;
            return this.View(viewModel);
        }
    }
}
