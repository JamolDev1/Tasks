using Microsoft.EntityFrameworkCore;

namespace Tasks.data
{
    public class TasksDbContext : DbContext
    {
         public DbSet<Tasks> Tasks { get; set; }
        
        
        public TasksDbContext(DbContextOptions options)
            : base(options)  { }
    }
}