using KinoPolis.Services.Mapping;
using System;
using KinoPolis.Data.Models;
namespace KinoPolis.Web.ViewModels.Films
{
    public class ByNameProjectionsViewModel : IMapFrom<Projection>
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string URL => $"/Projections/{this.Id}";

        public ByNameProjectionCinemaViewModel Cinema { get; set; }
    }
}