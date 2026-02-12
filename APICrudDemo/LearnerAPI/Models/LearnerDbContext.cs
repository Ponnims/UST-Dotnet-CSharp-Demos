using Microsoft.EntityFrameworkCore;

namespace LearnerAPI.Models
{
    public class LearnerDbContext :DbContext
    {

        public DbSet<Learner> Tbl_Learner { get; set; }

        public LearnerDbContext(DbContextOptions<LearnerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
