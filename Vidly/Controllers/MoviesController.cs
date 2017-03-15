using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            return View(_context.Movies.Include(m => m.Genre).ToList());
        }
        
        public ActionResult Details(int id)
        {
            return View(_context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id));
        }
    }
}