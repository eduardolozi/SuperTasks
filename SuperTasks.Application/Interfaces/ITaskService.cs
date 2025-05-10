namespace SuperTasks.Application.Interfaces;

public interface ITaskService
{
    Task Create(Domain.Models.Task task);
    Task<List<Domain.Models.Task>> GetAll();
}