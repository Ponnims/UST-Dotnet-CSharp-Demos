using Microsoft.EntityFrameworkCore;

namespace RESTAPIDEMO.Models
{
    public class TraineeDBContext:DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }

        public TraineeDBContext(DbContextOptions options):base(options)
        {
            
        }


    }
}
