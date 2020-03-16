// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VotingWeb.Controllers
{
    using global::VotingWeb.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System.Fabric;

    public class HomeController : Controller
    {
        private readonly StatelessServiceContext serviceContext;

        public HomeController(StatelessServiceContext context)
        {
            this.serviceContext = context;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                AppID = Startup.AppId.ToString(),
                NodeName = serviceContext.NodeContext.NodeName,
                RequestIP = ""
            };

            return this.View(viewModel);
        }

        public IActionResult Error()
        {
            return this.View();
        }
    }
}