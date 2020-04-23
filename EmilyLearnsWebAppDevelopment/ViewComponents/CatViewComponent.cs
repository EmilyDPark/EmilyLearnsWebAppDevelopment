using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmilyLearnsWebAppDevelopment.Services;
using EmilyLearnsWebAppDevelopment.Models;

namespace EmilyLearnsWebAppDevelopment.ViewComponents
{
    public class CatViewComponent : ViewComponent
    {
        private ICatProvider _cats;

        public CatViewComponent(ICatProvider cats)
        {
            _cats = cats;
        }

        public async Task<IViewComponentResult> InvokeAsync(string catName)
        {
            ViewBag.CurrentCat = await GetCat(catName);
            return View("SelectCat");
        }

        private Task<Cat> GetCat(string catName)
        {
            return Task.FromResult<Cat>(_cats[catName]);
        }
    }
}
