using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    //[Route("[controller]/[action]")]
    [SwaggerTag("Employee")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly string _connectionString;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDapperRepository _dapperrepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration connectionStrings, IDapperRepository dapperRepository)
        {
            _logger = logger;
            _connectionString = connectionStrings.GetConnectionString("DBConnectionForOpsArc");
            _dapperrepository = dapperRepository;
        }

        /// <summary>
        /// Searc Customer
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Code"></param>
        /// <param name="Type"></param>
        /// <param name="Parent"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("SearchEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DynamicListDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DynamicListDTO))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(DynamicListDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(DynamicListDTO))]
        public DynamicListDTO searchemployee()
        {
            DynamicListDTO listJobOrder = _dapperrepository.GellAllData(_connectionString);
            //if(string.IsNullOrEmpty(listJobOrder.errorMessage))
            //    {
            //    return Ok(listJobOrder);
            //}
            //else
            //{
            //    throw new ApiException
            //}
            return listJobOrder;
        }
    }
}
