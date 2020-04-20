using System;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<IndexFilmViewModel> Films { get; set; }
    }
}
