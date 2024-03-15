using IssueTracker_13557.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker_13557.Data
{
    public class IssueTrackerDbContext : DbContext
    {
        public IssueTrackerDbContext(DbContextOptions<IssueTrackerDbContext > options) : base(options) { }
        public DbSet<Issue> Issues { get; set; }     
    }
}
