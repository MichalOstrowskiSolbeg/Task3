using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DbModels;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly MyDbContext _context;
        public ReservationRepository(MyDbContext context)
        {
            _context = context;
        }

        public Reservation GetReservation(int id)
        {
            return _context.Reservations.Include(r => r.Employee)
                .Include(r => r.Workplace).First(x => x.Id == id);
        }

        public List<Reservation> GetReservations()
        {
            return _context.Reservations.Include(r => r.Employee)
                .Include(r => r.Workplace).ToList();
        }

        public void CreateReservation(Reservation request)
        {
            _context.Reservations.Add(request);
            _context.SaveChanges();
        }

        public void EditReservation(Reservation request)
        {
            _context.Reservations.Update(request);
            _context.SaveChanges();
        }

        public void DeleteReservation(int id)
        {
            _context.Reservations.Remove(_context.Reservations.Find(id));
            _context.SaveChanges();
        }

        public bool IsReservationDateAvailable(DateTime From, DateTime To, int workplaceId)
        {
            return !_context.Reservations
                .Where(x => x.WorkplaceId == workplaceId 
                && ((x.DateFrom > From && x.DateFrom < To) || (x.DateTo > From && x.DateTo < To) || (x.DateFrom <= From && x.DateTo >= To)))
                .Any();
        }

        public bool IsReservationDateAvailable(DateTime From, DateTime To, int workplaceId, int reservationID)
        {
            return !_context.Reservations
                .Where(x => x.Id != reservationID 
                && x.WorkplaceId == workplaceId 
                && ((x.DateFrom > From && x.DateFrom < To) || (x.DateTo > From && x.DateTo < To) || (x.DateFrom <= From && x.DateTo >= To)))
                .Any();
        }
    }
}