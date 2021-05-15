using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Service
{
    public class DapperRepository : IDapperRepository
    {
        List<dynamic> IDapperRepository.GellAllData()
        {
            throw new NotImplementedException();
        }
    }
}
