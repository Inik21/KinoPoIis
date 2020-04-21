using KinoPolis.Web.ViewModels.Projections;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Services.Data
{
    public interface IProjectionsService
    {
        public ByIdViewModel GetProjectionById(int id);
    }
}
