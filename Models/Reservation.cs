using System;
using System.Collections.Generic;

#nullable disable

namespace Task3.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int WorkplaceId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime WhenMade { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Workplace Workplace { get; set; }
    }
}
