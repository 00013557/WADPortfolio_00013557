using IssueTracker13557.Models;

namespace IssueTracker13557.Repository
{
    public interface IIssuesRepository
    {
        Task<IEnumerable<Issue>> GetAllIssues();
        Task<Issue> GetSingleIssue(int id);
        Task CreateIssue(Issue issue);
        Task UpdateIssue(Issue issue);
        Task DeleteIssue(int id);
    }
}
