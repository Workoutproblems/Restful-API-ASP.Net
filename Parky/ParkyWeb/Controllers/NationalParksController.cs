﻿using Microsoft.AspNetCore.Mvc;
using ParkyWeb.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb.Controllers
{
    public class NationalParksController : Controller
    {
        private readonly INationalParkRepository _npRepo;
        public IActionResult Index()
        {
            return View();
        }
    }
}