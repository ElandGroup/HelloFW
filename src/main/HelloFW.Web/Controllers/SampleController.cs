using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloFW.SampleMng.Service;
using Spring.Context.Support;

namespace HelloFW.Web.Controllers
{
    public class SampleController : Controller
    {
        public ISampleService SampleService
        {
            get
            {

                return ContextRegistry.GetContext().GetObject<ISampleService>("SampleService");
            }
        }
        // GET: Sample
        public ActionResult Index()
        {
            ViewBag.Date = SampleService.GetDate().ToString();
            return View();
        }
    }
}