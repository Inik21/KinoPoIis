using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;

namespace KinoPolis.Web.ViewModels.Administration.Films
{
    public class ByNameProjectionViewModel : IMapFrom<Projection>
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string URLDelete => $"/Administration/Projections/Delete/{this.Id}";
    }
}