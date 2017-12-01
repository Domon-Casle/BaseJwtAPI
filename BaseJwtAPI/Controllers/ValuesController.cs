using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BaseJwtAPI.Classes;

namespace BaseJwtAPI.Controllers
{
    // Protect this API with JWT tokens
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public OutPut Get()
        {
            return new OutPut() {Name = "Net Result:", Value = 25.03, UpperName="Testing Upper Name" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
