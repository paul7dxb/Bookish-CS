using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Bookish
{
    public class BookishDBContext : DbContext
    {
        // Put all the tables you want in your database here
        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BookCopyModel> Copies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            // This is the configuration used for connecting to the database
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=bookish;User Id=bookish;Password=bookish;");
        }
    }
}