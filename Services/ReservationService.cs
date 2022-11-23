using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Responses;
using Task3.Interfaces;
using Task3.Models;
using Task3.Repositories;

namespace Task3.Services
{
    public class ReservationService : IReservation
    {
        private readonly IReservationRepository _repository;
        private readonly IEmployeeRepository _repositoryEmployee;
        private readonly IReservationRepository _repositoryWorkplace;
        public ReservationService(IReservationRepository repository, IEmployeeRepository repositoryEmployee)
        {
            _repository = repository;
            _repositoryEmployee = repositoryEmployee;
        }

        public List<ReservationListResponse> GetAllReservations()
        {
            return _repository.GetReservations();
        }

        public List<EmployeeSelectResponse> GetEmployees()
        {
            return _repositoryEmployee.GetEmployeesSelection();
        }

        public List<Workplace> GetWorkplaces()
        {
            throw new NotImplementedException();
        }
    }
}