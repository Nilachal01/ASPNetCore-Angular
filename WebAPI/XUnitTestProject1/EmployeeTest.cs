using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;
using Xunit;
using XUnitTestProject1.TestConfig;

namespace XUnitTestProject1
{

    public class EmployeeTest : ApiTestConfig
    {
        [Fact]
        [Trait("Employee", "Get")]
        public async Task GetEmployee()
        {
            //Act
            var response = await _httpClient.GetAsync(GetRoutes.GetEmployees);
            var jsonresponse = response.Content.ReadAsStringAsync().Result;
            var employeedata = JsonConvert.DeserializeObject<DynamicListDTO>(jsonresponse);

            //Assert
            employeedata.Should().BeOfType<DynamicListDTO>();
        }


    }

}

