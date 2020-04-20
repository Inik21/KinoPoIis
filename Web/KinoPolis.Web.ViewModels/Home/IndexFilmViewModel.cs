using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Home
{
    public class IndexFilmViewModel : IMapFrom<Film>
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public string URL => $"/Film/{this.Name.Replace(' ', '-')}";
    }
}