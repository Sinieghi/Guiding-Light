using GuidingLight.Model;
using Name;

namespace GuidingLight.Services;
class UserServices
{
    private readonly GuidingLightContext? _context;

    public async Task CreateUserAsync(User user)
    {
        _context.Database.EnsureCreated();
        _context.Add(user);
        await _context.SaveChangesAsync();

    }
    public async Task<User> GetUserAsync(int userId)
    {
        var user = await _context.FindAsync<User>(userId);
        if (user == null) return null;
        return user;
    }

}