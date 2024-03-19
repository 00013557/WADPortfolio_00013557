﻿using IssueTracker13557.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker13557.Data
{
    public class IssueTrackerDbContext : DbContext
    {
        public IssueTrackerDbContext(DbContextOptions<IssueTrackerDbContext> options) : base(options) { }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
