using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.DTO.Requests
{
    public class ReservationRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int WorkplaceId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string ExceptionMessage { get; set; }
    }
}