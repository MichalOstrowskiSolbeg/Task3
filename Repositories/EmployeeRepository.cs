using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DbModels;
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

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Include(x => x.Reservations).First(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}