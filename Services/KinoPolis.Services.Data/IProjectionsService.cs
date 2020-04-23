namespace KinoPolis.Services.Data
{
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using KinoPolis.Web.ViewModels.Administration.Projections;
    using KinoPolis.Web.ViewModels.Projections;

    public interface IProjectionsService
    {
        ByIdViewModel GetProjectionById(int id);

        bool ValidateCinemaName(string cinemaName);

        bool ValidateHallInCinema(string cinemaName, int numberOfHall);

        Task CreateProjectionAsync(CreateImputModel input);

        Task DeleteProjectionByIdAsync(int id);
    }
}
