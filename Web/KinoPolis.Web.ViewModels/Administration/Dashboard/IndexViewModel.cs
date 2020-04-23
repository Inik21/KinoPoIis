using System.Collections;
using System.Collections.Generic;

namespace KinoPolis.Web.ViewModels.Administration.Dashboard
{
    public class IndexViewModel
    {
        public IEnumerable<IndexFilmViewModel> Films { get; set; }
    }
}
