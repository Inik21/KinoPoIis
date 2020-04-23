using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Administration.Dashboard
{
    public class IndexFilmViewModel : IMapFrom<Film>
    {
        public string Name { get; set; }

        public string URLDelete => $"/Administration/Films/Delete/{this.Name.Replace(' ', '-')}";

        public string URLAddProjection => $"/Administration/Projections/Create/{this.Name.Replace(' ', '-')}";

        public string URLSeeProjections => $"/Administration/Films/ByName/{this.Name.Replace(' ', '-')}";
    }
}