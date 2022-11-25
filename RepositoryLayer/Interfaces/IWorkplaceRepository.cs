using RepositoryLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RepositoryLayer.Interfaces
{
    public interface IWorkplaceRepository
    {
        List<Workplace> GetWorkplaces();
        Workplace GetWorkplace(int id);
    }
}