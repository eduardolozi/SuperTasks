namespace SuperTasks.Domain.Interfaces;

public interface ITaskRepository
{
    Task Create(Domain.Models.Task task);
    Task<List<Domain.Models.Task>> GetAll();
}