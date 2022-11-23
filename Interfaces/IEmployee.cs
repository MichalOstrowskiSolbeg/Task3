using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.Models;

namespace Task3.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
    }
}