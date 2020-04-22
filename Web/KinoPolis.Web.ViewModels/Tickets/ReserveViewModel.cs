using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Web.ViewModels.Tickets
{
    public class ReserveViewModel : IMapFrom<Ticket>
    {
        public int Id { get; set; }

        public string FirstNameOfBuyer { get; set; }

        public string SecondNameOfBuyer { get; set; }
    }
}
