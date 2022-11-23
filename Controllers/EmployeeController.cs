using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _service;
        public EmployeeController(IEmployee service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAllEmployees());
        }
    }
}
