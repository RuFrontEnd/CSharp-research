namespace Domain.Entities
{
    public interface IUserRepository
    {
        bool ExistsByEmail(string email);
    }
}
