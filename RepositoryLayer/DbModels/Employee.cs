using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryLayer.DbModels
{
    public partial class Employee
    {
        public Employee()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
