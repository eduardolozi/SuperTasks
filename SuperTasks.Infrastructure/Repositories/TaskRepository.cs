using Microsoft.EntityFrameworkCore;
using SuperTasks.Domain.Interfaces;

namespace SuperTasks.Infrastructure.Repositories;

public class TaskRepository(SuperTasksContext dbContext) : ITaskRepository
{
    public async Task Create(Domain.Models.Task task)
    {
        await dbContext.Tasks.AddAsync(task);
        await dbContext.SaveChangesAsync();
    }

    public Task<List<Domain.Models.Task>> GetAll()
    {
        return dbContext.Tasks.ToListAsync();
    }
}