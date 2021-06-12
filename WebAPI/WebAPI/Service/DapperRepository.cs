using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Service
{
    public class DapperRepository : IDapperRepository
    {
        public  DynamicListDTO GellAllData(string _connectionString)
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
                return listJobOrder;

            }
            catch (Exception ex)
            {
                 listJobOrder.errorMessage =Convert.ToString( ex.Message);
                return listJobOrder;
            }
           
        }
    }
}
