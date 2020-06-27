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
    [Route("[Controller]")]
    public class HealthController : Controller
    {
        public IActionResult Get()
        {
            return Ok("OK");
        }
    }
}
