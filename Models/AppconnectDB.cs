using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Configuration;
using System.Data;
//using static System.Collections.Immutable.ImmutableList<T>;

namespace interface_sugarcane_to_SAP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public class ApplicationContext : DbContext
        {
            public ApplicationContext(DbContextOptions options) : base(options) { }

            public DbSet<getpostsql> getpostsql { get; set; }
        }

    }
}





