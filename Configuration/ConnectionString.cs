using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace interface_sugarcane_to_SAP.Configuration
{
    public class ConnectionString
    {
        public const string Section = "ConnectionStrings";
        public string DefaultConnection { get; set; }
        public string PostgreSQLConnectiondb { get; set; }

    }
}
