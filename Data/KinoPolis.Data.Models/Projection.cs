using KinoPolis.Data.Common.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace KinoPolis.Data.Models
{
    public class Projection : BaseDeletableModel<int>
    {
        public Projection()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int Price { get; set; }

        public DateTime Time { get; set; }

        public int FilmId { get; set; }

        public virtual Film Film { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public int HallId { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}