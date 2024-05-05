using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrelloApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace PrelloApplication.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ProjectsController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index() 
        { 
            return View(_db.Projects.ToList()); 
        }

        // Get
        public IActionResult Create() {
            return View();
        }

        // next class, 3/31/24 POST for create
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        
    }
}
