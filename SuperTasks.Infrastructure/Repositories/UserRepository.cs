using Microsoft.EntityFrameworkCore;
using SuperTasks.Domain.Interfaces;
using SuperTasks.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace SuperTasks.Infrastructure.Repositories;

public class UserRepository(SuperTasksContext context) : IUserRepository
{
    public async Task Create(User user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public Task<User?> GetById(int id)
    {
        return context.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<List<User>> GetAll()
    {
        return context.Users.ToListAsync();
    }

    public Task Delete(int id)
    {
       return context.Users.Where(x => x.Id == id).ExecuteDeleteAsync();
    }
}