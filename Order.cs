namespace CarServiceDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        public int Car { get; set; }

        public int Service { get; set; }

        public int Worker { get; set; }

        public DateTime Date { get; set; }

        public bool Paid { get; set; }
        public virtual Car Car1 { get; set; }

        public virtual Service Service1 { get; set; }

        public virtual Worker Worker1 { get; set; }
    }
}
