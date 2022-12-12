using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        [HttpGet]
        public List<Owners> Get()
        {
            
        }
    }
}
