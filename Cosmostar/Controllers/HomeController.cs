using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmostar.Models;

namespace Cosmostar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order(OrderItemClass order)
        {
            ViewBag.Description = order.Description;
            ViewBag.Quantity = order.Quantity;
            ViewBag.OrderTime = order.OrderTime;

            var sum = order.Quantity * 25;
            ViewBag.Sum = sum;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
