using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Services.Data
{
    public interface ITicketsService
    {
        public int GetTicketId(int projectionId, int seat);
    }
}
