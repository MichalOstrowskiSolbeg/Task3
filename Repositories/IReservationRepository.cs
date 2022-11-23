using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Responses;

namespace Task3.Repositories
{
    public interface IReservationRepository
    {
        List<ReservationListResponse> GetReservations();
    }
}