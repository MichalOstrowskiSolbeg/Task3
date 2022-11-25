using ServiceLayer.DTO.Requests;
using ServiceLayer.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
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
        void DeleteReservation(int id);
    }
}
