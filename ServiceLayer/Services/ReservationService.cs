using RepositoryLayer.DbModels;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

using ServiceLayer.Interfaces;
using ServiceLayer.DTO.Responses;
using ServiceLayer.DTO.Requests;

namespace ServiceLayer.Services
{
    public class ReservationService : IReservation
    {
        private readonly IReservationRepository _repository;
        private readonly IEmployeeRepository _repositoryEmployee;
        private readonly IWorkplaceRepository _repositoryWorkplace;
        public ReservationService(IReservationRepository repository, IEmployeeRepository repositoryEmployee, IWorkplaceRepository workplaceRepository)
        {
            _repository = repository;
            _repositoryEmployee = repositoryEmployee;
            _repositoryWorkplace = workplaceRepository;
        }

        public List<ReservationResponse> GetAllReservations()
        {
            var list = _repository.GetReservations().ConvertAll(x => new ReservationResponse()
            {
                ID = x.Id,
                DateFrom = x.DateFrom,
                EmployeeId = x.EmployeeId,
                WorkplaceId = x.WorkplaceId,
                DateTo = x.DateTo,
                WhenMade = x.WhenMade,
                Employee = x.Employee.FirstName + " " + x.Employee.LastName,
                Workplace = x.WorkplaceId + " - " + x.Workplace.Description
            });

            return list;
        }

        public ReservationResponse GetReservation(int id)
        {
            var x = _repository.GetReservation(id);
            return new ReservationResponse()
            {
                ID = x.Id,
                Employee = x.Employee.FirstName + " " + x.Employee.LastName,
                DateFrom = x.DateFrom,
                DateTo = x.DateTo,
                WhenMade = x.WhenMade,
                Workplace = x.WorkplaceId + " - " + x.Workplace.Description
            };
        }

        public ReservationRequest GetReservationToEdit(int id)
        {
            var x = _repository.GetReservation(id);
            return new ReservationRequest()
            {
                Id = x.Id,
                DateFrom = x.DateFrom,
                DateTo = x.DateTo,
                EmployeeId = x.EmployeeId,
                WorkplaceId = x.WorkplaceId
            };
        }


        public void CreateReservation(ReservationRequest request)
        {
            if (_repository.IsReservationDateAvailable(request.DateFrom.Date, request.DateTo.Date, request.WorkplaceId))
            {
                _repository.CreateReservation(new Reservation
                {
                    EmployeeId = request.EmployeeId,
                    WorkplaceId = request.WorkplaceId,
                    DateFrom = request.DateFrom,
                    DateTo = request.DateTo,
                    WhenMade = DateTime.Now
                });
            }
            else
            {
                throw new Exception("Cannot create a reservation");
            }
        }

        public void EditReservation(ReservationRequest request)
        {
            if (_repository.IsReservationDateAvailable(request.DateFrom.Date, request.DateTo.Date, request.WorkplaceId, request.Id))
            {
                _repository.EditReservation(new Reservation
                {
                    Id = request.Id,
                    EmployeeId = request.EmployeeId,
                    WorkplaceId = request.WorkplaceId,
                    DateFrom = request.DateFrom,
                    DateTo = request.DateTo,
                    WhenMade = DateTime.Now
                });
            }
            else
            {
                throw new Exception("Cannot create a reservation");
            }
        }

        public void DeleteReservation(int id)
        {
            _repository.DeleteReservation(id);
        }



        public List<EmployeeSelectResponse> GetEmployees()
        {
            return _repositoryEmployee.GetEmployees().Select(s => new EmployeeSelectResponse
            {
                Id = s.Id,
                FullName = string.Format("{0} {1} ", s.FirstName, s.LastName)
            }).ToList();
        }

        public List<WorkplaceSelectResponse> GetWorkplaces()
        {
            return _repositoryWorkplace.GetWorkplaces().Select(s => new WorkplaceSelectResponse
            {
                Id = s.Id,
                Info = string.Format("{0} - {1} ({2})", s.Id, s.Description, string.Join(" ", s.WorkplaceItems.Select(x => x.Item.Name)))
            }).ToList();
        }
    }
}