using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace interface_sugarcane_to_SAP.MasterDB
{
    public partial class MasterContext : DbContext
    {
        public MasterContext()
        {
        }

        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<ArsTblColumn> ArsTblColumn { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Server==10.4.89.188;Port=5432;User Id=postgres;Password= Crist@ll@prog!@#;Database=sugarcanedb");
            }
        }
    }
}