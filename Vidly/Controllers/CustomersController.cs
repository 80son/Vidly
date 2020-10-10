using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
<<<<<<< HEAD
        private ApplicationDbContext _context;
=======
        public ApplicationDbContext _context;
>>>>>>> 2c041b800ef3e43a0c1cd2a9e9b63e1fdf803415

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
<<<<<<< HEAD

        // GET: Customers
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            
            return View(customer);
=======
        public ActionResult Index()
        {
            var customers = _context.Customers;

            return View(customers);
>>>>>>> 2c041b800ef3e43a0c1cd2a9e9b63e1fdf803415
        }



        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}