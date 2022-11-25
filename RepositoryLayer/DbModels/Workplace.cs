using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryLayer.DbModels
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
        public int Floor { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<WorkplaceItem> WorkplaceItems { get; set; }
    }
}
