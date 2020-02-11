using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class GreetController : Controller
    {
        public ViewResult Index(string name)
        {
            var model = new GreetModel();
            model.Name = name;
            return View(model);
        }
    }
}
