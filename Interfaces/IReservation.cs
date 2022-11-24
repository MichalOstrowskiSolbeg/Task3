using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Requests;
using Task3.DTO.Responses;
using Task3.Models;

namespace Task3.Interfaces
{
    public interface IReservation
    {
        List<ReservationResponse> GetAllReservations();
        ReservationResponse GetReservation(int id);
        ReservationRequest GetReservationToEdit(int id);
        List<EmployeeSelectResponse> GetEmployees();
        List<WorkplaceSelectResponse> GetWorkplaces();

        void CreateReservation(ReservationRequest request);
        void EditReservation(ReservationRequest request);
        void DeleteReservation(int Id);
    }
}
