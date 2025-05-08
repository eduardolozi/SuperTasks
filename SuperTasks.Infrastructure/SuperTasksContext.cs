using Microsoft.EntityFrameworkCore;
using SuperTasks.Domain.Models;
using Task = SuperTasks.Domain.Models.Task;

namespace SuperTasks.Infrastructure;

public class SuperTasksContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("DB_CONNECTIONSTRING"));
    }
}