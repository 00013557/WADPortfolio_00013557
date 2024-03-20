using IssueTracker13557.Data;
using IssueTracker13557.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker13557.Repository
{
    public class UsersRepository : IUsersRepository
    {
        //StudentID: 00013557
        private readonly IssueTrackerDbContext _dbContext;

        public UsersRepository(IssueTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var users = await _dbContext.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetSingleUser(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task CreateUser(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(b => b.Id == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
