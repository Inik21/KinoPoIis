using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Projections
{
    public class ByIdFilmViewModel : IMapFrom<Film>
    {
        public string Name { get; set; }

        public int Lenght { get; set; }

        public string ImgUrl { get; set; }

    }
}