using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Web.ViewModels.Home
{
    public class AZListViewModel
    {
        public IEnumerable<AZListFilmViewModel> Films { get; set; }
    }
}
