using Lesson43_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson43_Task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

    }
}
