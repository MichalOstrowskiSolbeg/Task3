using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DTO.Responses;
using Task3.Models;

namespace Task3.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MyDbContext _context;
        public EmployeeRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<EmployeeSelectResponse> GetEmployeesSelection()
        {
            return _context.Employees.Select(s => new EmployeeSelectResponse
            {
                Id = s.Id,
                FullName = string.Format("{0} {1}", s.FirstName, s.LastName)
            }).ToList();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}