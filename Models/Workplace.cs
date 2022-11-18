using System;
using System.Collections.Generic;

#nullable disable

namespace Task3.Models
{
    public partial class Workplace
    {
        public Workplace()
        {
            Reservations = new HashSet<Reservation>();
            WorkplaceItems = new HashSet<WorkplaceItem>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<WorkplaceItem> WorkplaceItems { get; set; }
    }
}
