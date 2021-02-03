using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http_5101_Assignment1_AlbyBaby_n01462455.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// it is a get request to return the id by squaring it
        /// get/api/square/{id}
        /// </summary>
        /// <returns>[id * id] </returns>
        public int Get(int id)
        {
            return (id * id);
        }
    }
}
