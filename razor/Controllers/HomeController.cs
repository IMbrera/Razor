using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using razor.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
                   Products[] array ={
             new Products {Name = "Tits", Price = 275M },
              new Products {Name = "bits", Price = 175M },
               new Products {Name = "hits", Price = 375M },
                new Products {Name = "shits", Price = 75M },

            };
            return View(array);
        }
    }
}
