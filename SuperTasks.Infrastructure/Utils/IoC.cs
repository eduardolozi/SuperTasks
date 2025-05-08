using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SuperTasks.Domain.Interfaces;
using SuperTasks.Infrastructure.Repositories;

namespace SuperTasks.Infrastructure.Utils;

public static class IoC
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<SuperTasksContext>();
        
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();
    } 
}