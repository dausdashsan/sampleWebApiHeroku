using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SampleWebApi.Controllers
{
    [ApiController]
    public class GeneratorController : ControllerBase
    {
        [HttpGet]
        [Route("/generator/randomNumber")]
        public IActionResult GenerateRandomNumber()
        {
            var random = new Random();
            int no = random.Next(1000000);

            return Ok(no);
        }

        [HttpGet]
        [Route("/generator/secretKey")]
        public IActionResult GenereteSecretKey()
        {
            var hmac = new HMACSHA256();
            string key = Convert.ToBase64String(hmac.Key);

            return Ok(key);
        }
    }
}
