using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApplication.Controllers
{
    public class TestController : Controller
    {

        //[HttpPost]
        public string Index()
        {
            return "hello world!";
        }


    }
}
