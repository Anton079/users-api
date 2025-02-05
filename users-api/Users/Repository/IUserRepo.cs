using users_api.Users.Models;

namespace users_api.Users.Repository
{
    public interface IUserRepo
    {

        Task<List<User>> GetUsersAsync();
    }
}
