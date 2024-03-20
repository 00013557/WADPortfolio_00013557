using IssueTracker13557.Data;
using IssueTracker13557.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker13557.Repository
{
    public class IssuesRepository : IIssuesRepository
    {
        //StudentID: 00013557
        private readonly IssueTrackerDbContext _dbContext;

        public IssuesRepository(IssueTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Issue>> GetAllIssues()
        {
            var issues = await _dbContext.Issues.Include(b => b.User).ToListAsync();
            return issues;
        }

        public async Task<Issue> GetSingleIssue(int id)
        {
            return await _dbContext.Issues.Include(b => b.User).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task CreateIssue(Issue issue)
        {
            await _dbContext.AddAsync(issue);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteIssue(int id)
        {
            var issue = await _dbContext.Issues.FirstOrDefaultAsync(b => b.Id == id);
            if (issue != null)
            {
                _dbContext.Issues.Remove(issue);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateIssue(Issue issue)
        {
            _dbContext.Entry(issue).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
