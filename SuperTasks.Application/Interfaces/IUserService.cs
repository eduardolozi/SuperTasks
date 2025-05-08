using SuperTasks.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace SuperTasks.Application.Interfaces;

public interface IUserService
{
    Task Create(User user);
    Task<User?> GetById(int id);
    Task<List<User>> GetAll();
    Task Delete(int id);  
}