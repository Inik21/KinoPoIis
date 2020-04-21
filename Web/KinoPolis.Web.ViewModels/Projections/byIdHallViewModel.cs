using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Projections
{
    public class ByIdHallViewModel : IMapFrom<Hall>
    {
        public int Rows { get; set; }

        public int SeatsPerRow { get; set; }

        public int Seats => this.Rows * this.SeatsPerRow;
    }
}