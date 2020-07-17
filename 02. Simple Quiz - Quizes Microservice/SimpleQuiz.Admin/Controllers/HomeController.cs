using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Admin.Models;
using SimpleQuiz.Common.Infrastructure;

namespace SimpleQuiz.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (this.User.IsAdministrator())
            {
                return this.RedirectToAction(nameof(DashboardController.Index), "Dashboard");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier
            });
    }
}