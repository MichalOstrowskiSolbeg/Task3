using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Responses;
using Task3.Models;

namespace Task3.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly MyDbContext _context;
        public ReservationRepository(MyDbContext context)
        {
            _context = context;
        }


        public List<ReservationListResponse> GetReservations()
        {
            var results = (from x in _context.Reservations
                           select new ReservationListResponse
                           {
                               ID = x.Id,
                               Employee = x.Employee.FirstName + " " + x.Employee.LastName,
                               DateFrom = x.DateFrom,
                               DateTo = x.DateTo,
                               WhenMade = x.WhenMade,
                               WorkplaceID = x.WorkplaceId
                           }).ToList();

            return results;
        }
    }
}
