using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class TestController : ControllerBase
    {
       [HttpGet]
        public string Test()
        {
            return "succeed";
        }
    }
}
