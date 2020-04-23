namespace KinoPolis.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using KinoPolis.Data.Common.Models;

    public class Film : BaseDeletableModel<int>
    {
        public Film()
        {
            this.Projections = new HashSet<Projection>();
        }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Country { get; set; }

        public int Year { get; set; }

        public int Lenght { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public virtual ICollection<Projection> Projections { get; set; }
    }
}
