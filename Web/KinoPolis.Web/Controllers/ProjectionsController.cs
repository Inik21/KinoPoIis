﻿namespace KinoPolis.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProjectionsController : BaseController
    {
        public IActionResult ById(int id)
        {

            return this.View();
        }
    }
}
