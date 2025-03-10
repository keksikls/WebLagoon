﻿using Microsoft.AspNetCore.Mvc;
using WebLagoon.Infrastructure.Data;

namespace WebLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();
            return View(villas);
        }

        public IActionResult Create() 
        {

            return View();
        }
    }
}
