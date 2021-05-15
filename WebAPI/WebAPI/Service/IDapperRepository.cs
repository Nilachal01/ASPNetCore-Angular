using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Service
{
    public interface IDapperRepository
    {
        //List<T> execute_sp(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
        // List GetAll(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
        List<dynamic> GellAllData();

    }
}
