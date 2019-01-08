using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        const string token = "1245ASDFA$%ASDFASGAS";
        //JSON in body
        //Content-Type: application/json
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Login([FromBody] UserLogin userLogin)
        {
            if (string.IsNullOrWhiteSpace(userLogin.Username)
                || string.IsNullOrWhiteSpace(userLogin.Password))
                return BadRequest();

            return token;
        }

        //Use QueryString
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Login2([FromQuery] UserLogin userLogin)
        {
            if (string.IsNullOrWhiteSpace(userLogin.Username)
                || string.IsNullOrWhiteSpace(userLogin.Password))
                return BadRequest();

            return token;
        }

        //Use FormFields in body
        //Content-Type: application/x-www-form-urlencoded
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Login3([FromForm] UserLogin userLogin)
        {
            if (string.IsNullOrWhiteSpace(userLogin.Username)
                || string.IsNullOrWhiteSpace(userLogin.Password))
                return BadRequest();

            return token;
        }
    }
}