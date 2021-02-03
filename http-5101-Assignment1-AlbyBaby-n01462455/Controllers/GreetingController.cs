using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http_5101_Assignment1_AlbyBaby_n01462455.Controllers
{
    public class GreetingController : ApiController
    {
      
        /// <summary>
        /// it is a post request to return a simple greeting
        /// Post/api/greeting
        /// </summary>
        /// <returns>"Hello World!" </returns>
        public string post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// it is a post request to return a simple greeting
        /// Get/api/greeting{id}
        /// </summary>
        /// <returns>"Greetings to {id} people" </returns>
        public string get(int id)
        {
            int number = id;
            string message = "Greetings to " + number.ToString() + " people";
            return message;
        }
    }
}
