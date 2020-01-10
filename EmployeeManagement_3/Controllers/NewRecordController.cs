using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement_3.Controllers
{
    public class NewRecordController : Controller
    {
        private readonly ConnectionStringClass _cc;

        public NewRecordController(ConnectionStringClass cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            var employees = _cc.EmpRegistration.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmpClass ec)
        {
            _cc.Add(ec);
            _cc.SaveChanges();
            ViewBag.message = "The record" + ec.EmpName + "is saved";
            return View();
        }
    }
}