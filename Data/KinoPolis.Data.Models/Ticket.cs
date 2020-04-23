namespace KinoPolis.Data.Models
{
    using System.Collections.Generic;

    using KinoPolis.Data.Common.Models;

    public class Ticket : BaseDeletableModel<int>
    {
        public string FirstNameOfBuyer { get; set; }

        public string SecondNameOfBuyer { get; set; }

        public int Row { get; set; }

        public int Seat { get; set; }

        public bool IsReserved { get; set; }

        public int ProjectionId { get; set; }

        public virtual Projection Projection { get; set; }
    }
}
