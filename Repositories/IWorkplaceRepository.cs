using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DbModels;

namespace Task3.Repositories
{
    public interface IWorkplaceRepository
    {
        List<Workplace> GetWorkplaces();
    }
}