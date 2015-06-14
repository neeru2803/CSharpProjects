using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            return "this is an contact page";

        }
        public string Details()
        {
            return "hello contact page";
        }
    }


}