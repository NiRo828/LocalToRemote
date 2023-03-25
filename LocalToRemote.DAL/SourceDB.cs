using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Configuration;
using LocalToRemote.Model;


namespace LocalToRemote.DAL
{
    public class SourceDB : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);

            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;");
        }
    }
}
