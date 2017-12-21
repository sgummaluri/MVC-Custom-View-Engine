using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomMVCViewEngine.Controllers
{
    public class SampleViewEngineController : Controller
    {
        // GET: SampleViewEngine
        public ActionResult Index()
        {
            // Add the data that you want to display
            var data = new List<string> { "One", "Two", "Three", "Four", "Five" };

            // Adding this to the Model property on ViewData as we are
            // fetching the data from the model property in our IView implementation.
            ViewData.Model = data;

            // We have hardcoded the view name as "CustomView" in our IViewEngineImplementation
            return View("CustomView");
        }
    }
}