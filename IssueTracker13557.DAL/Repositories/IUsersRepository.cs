using IssueTracker13557.Models;

namespace IssueTracker13557.Repository
{
    public interface IUsersRepository
    {
        //StudentID: 00013557
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetSingleUser(int id);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
