using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TC3Core.Services;
using TC3Core.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TC3Core.Controllers.Database
{
    [Authorize]
    public class BooksController : Controller
    {
        private IBookData _bookData;
        //private IGreeter _greeter;
        public BooksController(IBookData bookData)  //, IGreeter greeter)
        {
            _bookData = bookData;
            //_greeter = greeter;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new BookIndexViewModel
            {
                Books = _bookData.GetAll(),
            };
            return View(model);
        }
        public IActionResult Details(Guid id)
        {
            var model = _bookData.Get(id);
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
        //        var book = new Book()
        //        {
        //            Name = model.Name,
        //            Cuisine = model.Cuisine
        //        };
        //        book = _bookData.Add(book);
        //        return RedirectToAction(nameof(Details), new { id = book.ID });
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}
