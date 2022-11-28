using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.DTO.Responses
{
    public class ReservationResponse
    {
        public int ID { get; set; }
        public int EmployeeId { get; set; }
        public int WorkplaceId { get; set; }
        public string Employee { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime WhenMade { get; set; }
        public string Workplace { get; set; } 
    }
}