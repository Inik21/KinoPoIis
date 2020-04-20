using KinoPolis.Data.Common.Models;
using System.Collections;
using System.Collections.Generic;

namespace KinoPolis.Data.Models
{
    public class Cinema : BaseDeletableModel<int>
    {
        public Cinema()
        {
            this.Halls = new HashSet<Hall>();
            this.Projections = new HashSet<Projection>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }

        public virtual ICollection<Projection> Projections { get; set; }
    }
}
