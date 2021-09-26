using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Service
{
    public interface IDapperRepository
    {
        public DynamicListDTO GellAllData(string _connectionString);

    }
}
