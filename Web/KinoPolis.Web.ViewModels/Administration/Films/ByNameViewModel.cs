using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Web.ViewModels.Administration.Films
{
    public class ByNameViewModel : IMapFrom<Film>
    {
        public string Name { get; set; }

        public IEnumerable<ByNameProjectionViewModel> Projections { get; set; }

        
    }
}
