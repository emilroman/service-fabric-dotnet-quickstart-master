using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VotingWeb.Controllers
{
    [Route("[controller]")]
    public class HealthController : Controller
    {
        [HttpGet("")]
        public HttpStatusCode Index()
        {
            return HttpStatusCode.OK;
        }
    }
}