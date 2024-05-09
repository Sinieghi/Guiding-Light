using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;
using Name;

namespace GuidingLight.Services;
class UserServices
{
    private readonly GuidingLightContext? _context = new();

    public async Task CreateUserAsync(User user)
    {
        _context.Database.EnsureCreated();
        _context.Add(user);
        await _context.SaveChangesAsync();

    }
    public async Task<User> LoginAsync(string Email)
    {
        var has = await _context.User.AnyAsync(x => x.Email == Email);
        if (!has) return null;
        var user = await _context.User.Include(on => on.MySkills).Include(ob => ob.MyCompany).Include(ob => ob.ServicesDone).FirstOrDefaultAsync(u => u.Email == Email) ?? new User();
        return user;
    }
    public async Task<User> GetUserAsync(int userId)
    {
        var user = await _context.FindAsync<User>(userId);
        if (user == null) return null;
        return user;
    }

}