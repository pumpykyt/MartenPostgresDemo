using MartenDemo.Entities;

namespace MartenDemo.Interfaces;

public interface IUserService
{
    Task CreateUserAsync(User entity);
    Task<User> GetSingleUserAsync(Guid id);
    Task<IEnumerable<User>> GetAllUsersAsync();
}