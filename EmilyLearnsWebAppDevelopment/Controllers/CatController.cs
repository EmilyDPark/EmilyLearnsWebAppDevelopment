using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmilyLearnsWebAppDevelopment.Services;

namespace EmilyLearnsWebAppDevelopment.Controllers
{
    public class CatController : Controller
    {
        private ICatProvider _cats;

        public CatController(ICatProvider cats)
        {
            _cats = cats;
        }

        public IActionResult ShowCats()
        {
            ViewBag.Cats = _cats;
            return View();
        }

        public IActionResult ShowDataForCat(string catName)
        {
            ViewBag.Cat = _cats[catName];
            return View();
        }

        public IActionResult GetImage(string catName)
        {
            return File($@"catimages\{catName}.jpg", "image/jpeg");
        }
    }
}