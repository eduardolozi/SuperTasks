using Microsoft.Extensions.DependencyInjection;
using SuperTasks.Application.Interfaces;
using SuperTasks.Application.Services;

namespace SuperTasks.Application.Utils;

public static class IoC
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITaskService, TaskService>();
    }
}