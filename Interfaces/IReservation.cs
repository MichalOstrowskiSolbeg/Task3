using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Responses;
using Task3.Models;

namespace Task3.Interfaces
{
    public interface IReservation
    {
        List<ReservationListResponse> GetAllReservations();
        List<EmployeeSelectResponse> GetEmployees();
        List<Workplace> GetWorkplaces();
    }
}
