using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VotingWeb.Controllers
{
    public class HealthController : Controller
    {
        public HttpStatusCode Index()
        {
            return HttpStatusCode.OK;
        }
    }
}