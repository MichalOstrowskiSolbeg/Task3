using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.DTO.Requests;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Services;

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
            ViewData["WorkplaceId"] = new SelectList(_service.GetWorkplaces(), "Id", "Info");
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("EmployeeId,WorkplaceId,DateFrom,DateTo")] ReservationRequest request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.CreateReservation(request);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    ViewData["EmployeeId"] = new SelectList(_service.GetEmployees(), "Id", "FullName");
                    ViewData["WorkplaceId"] = new SelectList(_service.GetWorkplaces(), "Id", "Info");
                    request.ExceptionMessage = e.Message;
                    return View(request);
                }
            }
            ViewData["EmployeeId"] = new SelectList(_service.GetEmployees(), "Id", "FullName");
            ViewData["WorkplaceId"] = new SelectList(_service.GetWorkplaces(), "Id", "Info");
            return View(request);
        }

        public IActionResult Details(int id)
        {
            return View(_service.GetReservation(id));
        }

        public IActionResult Edit(int id)
        {
            ViewData["EmployeeId"] = new SelectList(_service.GetEmployees(), "Id", "FullName");
            ViewData["WorkplaceId"] = new SelectList(_service.GetWorkplaces(), "Id", "Info");
            return View(_service.GetReservationToEdit(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,EmployeeId,WorkplaceId,DateFrom,DateTo")] ReservationRequest request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.EditReservation(request);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    ViewData["EmployeeId"] = new SelectList(_service.GetEmployees(), "Id", "FullName");
                    ViewData["WorkplaceId"] = new SelectList(_service.GetWorkplaces(), "Id", "Info");
                    request.ExceptionMessage = e.Message;
                    return View(request);
                }
            }
            ViewData["EmployeeId"] = new SelectList(_service.GetEmployees(), "Id", "FullName");
            ViewData["WorkplaceId"] = new SelectList(_service.GetWorkplaces(), "Id", "Info");
            return View(request);
        }

        public IActionResult Delete(int id)
        {
            _service.DeleteReservation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}