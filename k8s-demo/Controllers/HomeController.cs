using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using k8s_demo.Models;

namespace k8s_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.DateTime = DateTime.Now.ToString();
            ViewBag.name = Environment.GetEnvironmentVariable("HOSTNAME_COMMAND");

            _logger.LogInformation($"{DateTime.Now.ToString()} IP：{HttpContext.Connection.RemoteIpAddress.ToString()}   ----   Host：{HttpContext.Request.Host} 访问了Index页面");
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.DateTime = DateTime.Now.ToString();
            ViewBag.name = Environment.GetEnvironmentVariable("HOSTNAME_COMMAND");

            _logger.LogInformation($"{DateTime.Now.ToString()} IP：{HttpContext.Connection.RemoteIpAddress.ToString()}   ----   Host：{HttpContext.Request.Host} 访问了Privacy页面");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
