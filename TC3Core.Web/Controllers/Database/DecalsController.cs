using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TC3Core.Services;
using TC3Core.ViewModels;

namespace TC3Core.Controllers.Database
{
    public class DecalsController : Controller
    {
        private IDecalData _decalData;
        //private IGreeter _greeter;
        public DecalsController(IDecalData decalData)   //, IGreeter greeter)
        {
            _decalData = decalData;
            //_greeter = greeter;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new DecalsViewModel
            {
                Decals = _decalData.GetAll(),
            };
            return View(model);
        }
        public IActionResult Details(Guid id)
        {
            var model = _decalData.Get(id);
            if (model == null)
            {
                //return View("NotFound");
                //return NotFound();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(BookEditModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var decal = new Decal()
        //        {
        //            Name = model.Name,
        //            Cuisine = model.Cuisine
        //        };
        //        decal = _decalData.Add(book);
        //        return RedirectToAction(nameof(Details), new { id = decal.ID });
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}