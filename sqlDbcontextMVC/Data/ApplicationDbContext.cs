using Microsoft.EntityFrameworkCore;
using sqlDbcontextMVC.Models;

namespace sqlDbcontextMVC.Data
{
    //This class inherit from DbContext which is from EntityFrameworkCore
    public class ApplicationDbContext : DbContext
    {

        //1. Adding constructor class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        //2. Making the books table in sql database
        public DbSet<Book> books { get; set; }
    }
}
