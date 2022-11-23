using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.DTO.Responses
{
    public class ReservationListResponse
    {
        public int ID { get; set; }
        public string Employee { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime WhenMade { get; set; }
        public int WorkplaceID { get; set; } 
    }
}