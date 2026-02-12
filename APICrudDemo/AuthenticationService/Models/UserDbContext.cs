using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.Models
{
    public class UserDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
