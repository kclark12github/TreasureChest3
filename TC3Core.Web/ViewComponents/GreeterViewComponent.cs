using Microsoft.AspNetCore.Mvc;
using TC3Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TC3Core.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public IViewComponentResult Invoke()
        {
            return View("Default", _greeter.GetMessageOfTheDay());  //Avoid framework mistaking a View name with our message string by explicitly passing "Default" View name...
        }
    }
}
