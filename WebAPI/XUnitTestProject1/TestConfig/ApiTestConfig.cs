using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject1.TestConfig
{
    public class ApiTestConfig
    {
        protected readonly HttpClient _httpClient;

        public ApiTestConfig()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ClientTestSetup.BaseAddress);
            _httpClient.DefaultRequestHeaders.Add(ClientTestSetup.AcceptHeader, ClientTestSetup.AcceptHeaderValue);
        }

    }
}
