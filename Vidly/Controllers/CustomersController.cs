﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(_context.Customers.ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Customers.SingleOrDefault(c => c.Id == id));
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var cList = new List<Customer>();
            cList.Add(new Customer { Id = 1, Name = "Mary Williams" });
            cList.Add(new Customer { Id = 2, Name = "John Smith" });
            return cList;
        }
    }
}