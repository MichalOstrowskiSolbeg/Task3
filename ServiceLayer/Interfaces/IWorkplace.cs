using RepositoryLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IWorkplace
    {
        List<Workplace> GetWorkplaces();
        Workplace GetWorkplace(int id);
    }
}