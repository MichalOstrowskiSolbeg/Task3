using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.Interfaces;
using Task3.Services;

namespace Task3.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservation _service;
        public ReservationController(IReservation service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAllReservations());
        }

        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_service.GetEmployees(), "Id", "FullName");
            //ViewData["WorkplaceId"] = new SelectList(_context.Workplaces, "Id", "Description");
            return View();
        }
    }
}