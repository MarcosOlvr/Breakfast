using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuberBreakfast.Controllers
{
    [Route("/error")]
    public class ErrorsController : ControllerBase
    {
        public IActionResult Error()
        {
            return Problem();
        }
    }
}