using KinoPolis.Web.ViewModels.Administration.Cinemas;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public interface ICinemasService
    {
        Task CreateCinemaAsync(CreateInputModel input);
    }
}
