using RepositoryLayer.DbModels;
using RepositoryLayer.Interfaces;
using System.Collections.Generic;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Services
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