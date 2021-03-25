using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollectorSite.Data;
using TrashCollectorSite.Models;

namespace TrashCollectorSite.Controllers
{
    public class EmployeeController : Controller
    {
        public ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EmployeeController1
        public ActionResult Index()
        {
            //query customer table to find customers in same zip code as employee who is logged in and have a pickup that is today

            //1. ^^ query employee table for logged in employee 
            //2. ^^ get today's day of week -- DateTime
            //3. ^^ query the customer table for any customers that have the same zip as the logged in employee
            //4. ^^ query the customers with same zip and find who has a pickup day that is equal to today
            //5. ^^ pass those customers to the view

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            string day = DateTime.Now.DayOfWeek.ToString();
            var zipCustomers = _context.Customer.Where(cust => cust.Zip.Equals(employee.Zip));
            var todayPickup = zipCustomers.Where(cust => cust.PickUpDay == day);

            return View(todayPickup);
        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee newEmployee)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                newEmployee.IdentityUserId = userId;
                _context.Employee.Add(newEmployee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
