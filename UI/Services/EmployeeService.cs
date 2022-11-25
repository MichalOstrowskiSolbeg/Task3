﻿using RepositoryLayer.DbModels;
using RepositoryLayer.Interfaces;
using System.Collections.Generic;
using Task3.Interfaces;

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

        public Employee GetEmployee(int id)
        {
            return _repository.GetEmployee(id);
        }
    }
}