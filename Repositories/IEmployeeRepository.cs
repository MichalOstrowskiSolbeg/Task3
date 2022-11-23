using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Responses;
using Task3.Models;

namespace Task3.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();

        List<EmployeeSelectResponse> GetEmployeesSelection();
    }
}