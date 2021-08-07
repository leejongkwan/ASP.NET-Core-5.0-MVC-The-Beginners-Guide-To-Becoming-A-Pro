using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApplication.Controllers
{
    /// <summary>
    /// Appointment ViewModel class
    /// </summary>
    public class Appointment
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public int duration { get; set; }
    }

    /// <summary>
    /// Appointment Controller
    /// </summary>
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //it will return index view (Appointment/Index)
            return View();
        }

        #region :: Passing parameter to URL ::

        //[Route("{id}")]
        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    return Ok("You have entered : {id}" + id);
        //}

        [HttpGet]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok("You have entered : {id}" + id);
        }

        #endregion

        #region :: Pass parameters with query string ::

        public IActionResult GetSomeData([FromQuery] string values)
        {
            //it will print the below string concated with the values passed as query string in action
            return Ok("The value : " + values + " is from Query string");
        }

        #endregion

        #region :: Pass parameters with headers ::

        [HttpPost]
        public IActionResult Post([FromHeader] string parentRequestId)
        {
            //it will print the below string concated with parentRequestId passed as Form Header in the action
            return Ok($"Got a header with parentRequestId: {parentRequestId}!");
        }

        #endregion

        #region :: Pass parameters using form body ::

        [HttpPost]
        public IActionResult AddAppointment([FromBody] Appointment appointment)
        {
            //it will open up the view with the passed object as parameter
            return Ok(appointment);
        }

        #endregion

        #region :: Pass parameters in a form ::

        [HttpPost]
        public IActionResult SaveFile([FromForm] string filename, [FromForm] IFormFile file)
        {

            //print success
            return Ok("Success");
        }


        [NonAction]
        public int DoSomeCalculations(int id)
        {
            return 0;
        }




        #endregion

    }
}