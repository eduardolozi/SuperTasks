using SuperTasks.Application.Interfaces;
using SuperTasks.Domain.Interfaces;

namespace SuperTasks.Application.Services;

public class TaskService(ITaskRepository taskRepository) : ITaskService
{
    public Task Create(Domain.Models.Task task)
    {
        return taskRepository.Create(task);
    }

    public Task<List<Domain.Models.Task>> GetAll()
    {
        return taskRepository.GetAll();
    }
}