namespace KinoPolis.Web.Controllers
{
    using System.Diagnostics;

    using KinoPolis.Services.Data;
    using KinoPolis.Web.ViewModels;
    using KinoPolis.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IFilmsService filmsService;

        public HomeController(IFilmsService filmsService)
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

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
