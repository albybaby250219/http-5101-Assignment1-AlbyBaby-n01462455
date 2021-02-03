using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http_5101_Assignment1_AlbyBaby_n01462455.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// it is a get request to return the id by adding 10
        /// get/api/addten/{id}
        /// </summary>
        /// <returns>[id+10] </returns>
        public int Get(int id)
        {
            return  (id + 10) ;
        }
    }
}
