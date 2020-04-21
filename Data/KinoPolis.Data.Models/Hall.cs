namespace KinoPolis.Data.Models
{
    using System.Collections.Generic;

    using KinoPolis.Data.Common.Models;

    public class Hall : BaseDeletableModel<int>
    {

        public Hall()
        {
            this.Projections = new HashSet<Projection>();
        }

        public int NumberofHall { get; set; }

        public int Rows { get; set; }

        public int SeatsPerRow { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<Projection> Projections { get; set; }
    }
}