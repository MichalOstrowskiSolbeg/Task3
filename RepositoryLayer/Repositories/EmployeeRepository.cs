using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DbModels;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RepositoryLayer.Repositories
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