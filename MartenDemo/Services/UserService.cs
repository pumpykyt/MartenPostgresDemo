using Marten;
using MartenDemo.Entities;
using MartenDemo.Interfaces;

namespace MartenDemo.Services;

public class UserService : IUserService
{
    private readonly IDocumentSession _session;
    
    public UserService(IDocumentSession session)
    {
        _session = session;
    }

    public async Task CreateUserAsync(User entity)
    {
        _session.Store(entity);
        await _session.SaveChangesAsync();
    }

    public async Task<User> GetSingleUserAsync(Guid id) => await _session.LoadAsync<User>(id);

    public async Task<IEnumerable<User>> GetAllUsersAsync() => await _session.Query<User>().ToListAsync();
}