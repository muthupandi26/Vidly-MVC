﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult RandomTest()
        {
            return Content("Hello Test Controller");
        }

    }
}