using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DbModels;

namespace Task3.Interfaces
{
    public interface IWorkplace
    {
        List<Workplace> GetWorkplaces();
        Workplace GetWorkplace(int id);
    }
}