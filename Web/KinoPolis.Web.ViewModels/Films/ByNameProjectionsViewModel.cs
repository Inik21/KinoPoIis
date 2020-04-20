using KinoPolis.Services.Mapping;
using System;
using KinoPolis.Data.Models;
namespace KinoPolis.Web.ViewModels.Films
{
    public class ByNameProjectionsViewModel : IMapFrom<Projection>
    {
        public DateTime Time { get; set; }

        public ByNameProjectionCinemaViewModel Cinema { get; set; }
    }
}