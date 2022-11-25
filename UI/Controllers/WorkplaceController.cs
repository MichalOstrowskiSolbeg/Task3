using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;

namespace Task3.Controllers
{
    public class WorkplaceController : Controller
    {
        private readonly IWorkplace _service;
        public WorkplaceController(IWorkplace service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            return View(_service.GetWorkplaces());
        }

        public IActionResult Details(int id)
        {
            return View(_service.GetWorkplace(id));
        }
    }
}
