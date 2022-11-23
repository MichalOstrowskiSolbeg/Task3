using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.Interfaces;
using Task3.Models;
using Task3.Repositories;

namespace Task3.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetEmployees();
        }
    }
}