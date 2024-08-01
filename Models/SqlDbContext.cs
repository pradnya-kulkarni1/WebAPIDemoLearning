using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDemoLearning.Models
{
    public class SqlDbContext : DbContext
    {
        // The EF model of a database!

       public DbSet<User> Users { get; set; } // represents model of database

        //public DbSet<ProductHeaderValue> Products { get; set; }

        public SqlDbContext( DbContextOptions<SqlDbContext>options ): base( options )
        { 

        }
    }
}
