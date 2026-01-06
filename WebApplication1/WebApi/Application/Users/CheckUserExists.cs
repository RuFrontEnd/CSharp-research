using Domain.Interfaces;
using Domain.Entities;

namespace Application.Users;

public class CheckUserExists
{
    private readonly IUserRepository _repo;

    public CheckUserExists(IUserRepository repo)
    {
        _repo = repo;
    }

    public bool Execute(string email)
    {
        return _repo.ExistsByEmail(email);
    }
}
