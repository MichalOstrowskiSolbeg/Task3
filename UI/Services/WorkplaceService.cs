using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DbModels;
using Task3.Interfaces;
using Task3.Models;
using Task3.Repositories;

namespace Task3.Services
{
    public class WorkplaceService : IWorkplace
    {
        private readonly IWorkplaceRepository _repository;
        public WorkplaceService(IWorkplaceRepository repository)
        {
            _repository = repository;
        }

        public Workplace GetWorkplace(int id)
        {
            return _repository.GetWorkplace(id);
        }

        public List<Workplace> GetWorkplaces()
        {
            return _repository.GetWorkplaces();
        }
    }
}