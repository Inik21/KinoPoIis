using KinoPolis.Web.ViewModels.Administration.Halls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public interface IHallsService
    {
        Task CreateHallAsync(CreateInputModel input);

        bool ValidateHallExist(string cinemaName, int numberOfHall);
    }
}
