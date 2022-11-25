using RepositoryLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}