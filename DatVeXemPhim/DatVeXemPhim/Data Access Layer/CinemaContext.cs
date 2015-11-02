using DatVeXemPhim.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DatVeXemPhim.Data_Access_Layer
{
    public class CinemaContext : DbContext
    {
        public CinemaContext() : base("CinemaContext"){
        }

        public DbSet<Movie> Movies { get; set; }
        
         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}