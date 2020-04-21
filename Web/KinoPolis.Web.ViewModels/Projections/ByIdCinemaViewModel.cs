using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Projections
{
    public class ByIdCinemaViewModel : IMapFrom<Cinema>
    {
        public string Name { get; set; }
    }
}