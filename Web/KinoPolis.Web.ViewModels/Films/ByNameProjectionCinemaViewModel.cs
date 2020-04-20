using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Films
{
    public class ByNameProjectionCinemaViewModel : IMapFrom<Cinema>
    {
        public string Name { get; set; }

        public string Adress { get; set; }
    }
}