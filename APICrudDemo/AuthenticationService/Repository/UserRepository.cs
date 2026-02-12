using AuthenticationService.Models;

namespace AuthenticationService.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext dbcontext;
        public UserRepository(UserDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public User Login(User user)
        {
            return dbcontext.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
        }

        public void Register(User user)
        {
            dbcontext.Users.Add(user);
            dbcontext.SaveChanges();
        }
    }
}
