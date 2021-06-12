using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly string _connectionString;

        /// <summary>
        /// CRM Constructor
        /// </summary>
        /// <param name="connectionStrings"></param>
        public HomeController(IConfiguration connectionStrings)
        {
            _connectionString = connectionStrings.GetConnectionString("DBConnectionForOpsArc");

        }
    }
}
