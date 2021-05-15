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

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration connectionStrings)
        {
            _logger = logger;
            _connectionString = connectionStrings.GetConnectionString("DBConnectionForOpsArc");
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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public dynamic searchemployee()
        {
            DynamicListDTO listJobOrder = new DynamicListDTO();

            try
            {

                using (System.Data.SqlClient.SqlConnection activeConn = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    activeConn.Open();
                    //var p = new Dapper.DynamicParameters();
                    //p.Add("@Name", Name, dbType: DbType.String);
                    //p.Add("@Type", Type, dbType: DbType.String);
                    //p.Add("@Code", Code, dbType: DbType.String);
                    //p.Add("@Parent", Parent, dbType: DbType.String);
                    listJobOrder.thisList = activeConn.Query<dynamic>("TestProcInitial", commandType: System.Data.CommandType.StoredProcedure).ToList();
                }

                return Ok(listJobOrder);
            }
            catch (Exception ex)
            {
                return listJobOrder.errorMessage = ex.Message;
            }

        }
    }
}
