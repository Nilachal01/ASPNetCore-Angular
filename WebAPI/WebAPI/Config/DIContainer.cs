using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Service;

namespace WebAPI.Config
{
    public class DIContainer
    {
        public static void Integrate(IServiceCollection service, IConfiguration Configuration)
        {
            service.AddScoped<IDapperRepository, DapperRepository>();

        }
    }
}
