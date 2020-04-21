using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Projections
{
    public class ByIdTicketViewModel : IMapFrom<Ticket>
    {
        public int Row { get; set; }

        public int Seat { get; set; }

        public bool IsReserved { get; set; }
    }
}