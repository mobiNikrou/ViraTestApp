using Microsoft.EntityFrameworkCore;
using ViraTestApp.Models;

namespace ViraTestApp.Data
{
    public class TestResultContext : DbContext
    {
        public TestResultContext (DbContextOptions<TestResultContext> options)
            : base(options)
        {
        }

        public DbSet<TestingResult> TestingResult { get; set; }
    }
}