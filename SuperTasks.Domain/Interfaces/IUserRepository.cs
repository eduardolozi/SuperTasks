using SuperTasks.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace SuperTasks.Domain.Interfaces;

public interface IUserRepository
{
    Task Create(User user);
    Task<User?> GetById(int id);
    Task<List<User>> GetAll();
    Task Delete(int id);
}