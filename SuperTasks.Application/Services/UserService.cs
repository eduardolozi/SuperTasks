using SuperTasks.Application.Interfaces;
using SuperTasks.Domain.Interfaces;
using SuperTasks.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace SuperTasks.Application.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public Task Create(User user)
    {
        return userRepository.Create(user);
    }

    public Task<User?> GetById(int id)
    {
        return userRepository.GetById(id) 
               ?? throw new Exception("User not found");
    }

    public Task<List<User>> GetAll()
    {
        return userRepository.GetAll();
    }

    public Task Delete(int id)
    {
        return userRepository.Delete(id);
    }
}