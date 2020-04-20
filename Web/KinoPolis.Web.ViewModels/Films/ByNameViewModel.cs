using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Web.ViewModels.Films
{
    public class ByNameViewModel : IMapFrom<Film>
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string Country { get; set; }

        public int Year { get; set; }

        public int Lenght { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public IEnumerable<ByNameProjectionsViewModel> Projections { get; set; }

    }
}
