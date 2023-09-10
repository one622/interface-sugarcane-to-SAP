using interface_sugarcane_to_SAP.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;
using System.Runtime.InteropServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql;
using System.Collections.Generic;


namespace interface_sugarcane_to_SAP.Repository
{
    public interface ISelecttableRepository
    {
        List<getpostsql> Loadgetpostsql();

    }

}





