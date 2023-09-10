using interface_sugarcane_to_SAP.Models;
using Microsoft.EntityFrameworkCore;

namespace interface_sugarcane_to_SAP.ConnextDB
{
    public class ContextDB : DbContext
    {

        private readonly DbContextOptions<ContextDB> options;
        public ContextDB(DbContextOptions<ContextDB>options) :base(options) 
        
        {
            this.options = options;
        }
         
        
            public DbSet<getpostsql> getpostsqs {  get; set; } 

    }
}



