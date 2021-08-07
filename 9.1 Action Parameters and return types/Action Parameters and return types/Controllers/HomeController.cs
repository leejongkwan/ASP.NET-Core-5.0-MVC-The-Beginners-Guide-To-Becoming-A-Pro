using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    /// <summary>
    /// Default controller as a result of scaffolding of project
    /// </summary>
    public class HomeController : Controller
    {
        //Initialized logger interface
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Constructor of Home controller with dependency injection to logger.
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Index method of Home controller, it will invoke the view name Index under Home folder.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //it will return and render the view
            return View();
        }



        /// <summary>
        /// Privacy method of Home controller, it will invoke the view name Privacy under Home folder.
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            //it will return and render the view
            return View();
        }

        /// <summary>
        /// it will render the errors on error view
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
