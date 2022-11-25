using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DbModels;
using Task3.DTO.Requests;
using Task3.DTO.Responses;
using Task3.Models;

namespace Task3.Repositories
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