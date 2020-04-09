using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmilyLearnsWebAppDevelopment.Models;

namespace EmilyLearnsWebAppDevelopment.Controllers
{
    public class CreationsController : Controller
    {
        private ICreationData _tempData;
        public CreationsController(ICreationData tempData)
        {
            _tempData = tempData;
        }

        public IActionResult Index()
        {
            List<Creation> creations = _tempData.CreationsInitializeData();
            CreationIndexViewModel creationIndexViewModel = new CreationIndexViewModel();
            creationIndexViewModel.Creations = creations;
            return View(creationIndexViewModel);
        }

        public IActionResult Details(int? id)
        {
            var model = _tempData.GetCreationById(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}