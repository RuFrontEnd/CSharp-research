using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private readonly List<string> _emails = new List<string>
    {
        "test@mail.com",
        "admin@mail.com"
    };

        public bool ExistsByEmail(string email)

        {
            return _emails.Contains(email);
        }
    }
}
