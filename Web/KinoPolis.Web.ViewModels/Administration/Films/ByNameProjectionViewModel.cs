namespace KinoPolis.Web.ViewModels.Administration.Films
{
    using System;

    using KinoPolis.Data.Models;
    using KinoPolis.Services.Mapping;

    public class ByNameProjectionViewModel : IMapFrom<Projection>
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string URLDelete => $"/Administration/Projections/Delete/{this.Id}";
    }
}
