using KinoPolis.Web.ViewModels.Tickets;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KinoPolis.Services.Data
{
    public interface ITicketsService
    {
        public int GetTicketId(int projectionId, int seat);

        public ReserveViewModel GetViewModel(int ticketId);

        public Task ReserveTicketAsync(ReserveViewModel input);
    }
}
