using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Web.ViewModels.Projections
{
    public class ByIdViewModel : IMapFrom<Projection>
    {
        public int Id { get; set; }

        public int TicketSeat { get; set; }

        public int Price { get; set; }

        public DateTime Time { get; set; }

        public ByIdFilmViewModel Film { get; set; }

        public ByIdCinemaViewModel Cinema { get; set; }

        public ByIdHallViewModel Hall { get; set; }

        public IEnumerable<ByIdTicketViewModel> Tickets { get; set; }
    }
}
