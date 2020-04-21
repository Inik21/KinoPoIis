using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;

namespace KinoPolis.Web.ViewModels.Projections
{
    public class ByIdTicketViewModel : IMapFrom<Ticket>
    {
        public int Id { get; set; }

        public int Row { get; set; }

        public int Seat { get; set; }

        public bool IsReserved { get; set; }

        public string URL => $"/Tickets/{Id}";
    }
}