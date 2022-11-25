using RepositoryLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        Reservation GetReservation(int id);
        void CreateReservation(Reservation request);
        void EditReservation(Reservation request);
        void DeleteReservation(int id);
        bool IsReservationDateAvailable(DateTime from, DateTime to, int workplaceId);
        bool IsReservationDateAvailable(DateTime from, DateTime to, int workplaceId, int reservationID);
    }
}