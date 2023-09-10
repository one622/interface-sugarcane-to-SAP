using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;
using interface_sugarcane_to_SAP.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Security.Cryptography.Xml;
using Npgsql.Internal;
using interface_sugarcane_to_SAP.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using interface_sugarcane_to_SAP.Configuration;
using Dapper;

namespace interface_sugarcane_to_SAP.Repository
{
    public class SelecttableRepository : ISelecttableRepository
    {

      

        private readonly IConfiguration _configuration;
        private readonly AppSetting _appsetting;

        private readonly IHttpContextAccessor _httpContextAccessor;

        

        private string connectionString;

        private ConnectionString _connections;
        public SelecttableRepository(IConfiguration configuration,
            IOptions<ConnectionString> connections)
        {
            _connections = connections.Value;
            connectionString = _connections.PostgreSQLConnectiondb;

        }
        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }


        public List<getpostsql> Loadgetpostsql()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                //var data = dbConnection.Query<Farmarea>($@"select * from farmarea f where dataareaid ='104' and crop_year ='66/67' and my_location_name ='10814-02')";

                var data = dbConnection.Query<getpostsql>($@"
                            SELECT truckoil,vehicle_code,transdate::date,oilamoun,uid,approvestatus,approver

                                        FROM public.sugarcanetransoil where dataareaid = '102'

                                          and public.sugarcanetransoil.approvestatus = 0

                                          and public.sugarcanetransoil.truckoil = 'O0001'

                                          and public.sugarcanetransoil.finish_addfuel = 1

                                          ORDER BY UID");




                return data.ToList();

            }

        }


       
    }
}





