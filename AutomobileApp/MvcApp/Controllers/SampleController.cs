using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            var listItems = new List<SampleViewModel>();

            listItems.Add(new SampleViewModel { SampleId = 100, SampleName = "neeraja" });
            listItems.Add(new SampleViewModel { SampleId = 102, SampleName = "subha" });
            listItems.Add(new SampleViewModel { SampleId = 103, SampleName = "vidwan" });
            listItems.Add(new SampleViewModel { SampleId = 104, SampleName = "deepika" });
            listItems.Add(new SampleViewModel { SampleId = 105, SampleName = "Nani" });
            return View(listItems);
        }

    }
    public class SampleViewModel
    {
        public int SampleId { get; set; }
        public string SampleName { get; set; }
    }
}