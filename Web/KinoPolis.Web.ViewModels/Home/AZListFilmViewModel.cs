using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Home
{
    public class AZListFilmViewModel : IMapFrom<Film>
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public string URL => $"/Films/{this.Name.Replace(' ', '-')}";
    }
}