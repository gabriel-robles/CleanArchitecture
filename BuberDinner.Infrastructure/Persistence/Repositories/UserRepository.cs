using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.UserAggregate;

namespace BuberDinner.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> Users = new();

        public void Add(User user)
        {
            Users.Add(user);
        }

        public User GetUserByEmail(string email)
        {
            return Users.SingleOrDefault(u => u.Email == email);
        }
    }
}