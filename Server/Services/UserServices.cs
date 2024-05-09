using System.Web.Helpers;
using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;
using Name;

namespace GuidingLight.Services;
class UserServices
{
    private readonly GuidingLightContext? _context = new();

    public async Task CreateUserAsync(User user)
    {
        if (user.Password != "" || user.Email != "" || user.Name != "")
        {
            _context.Database.EnsureCreated();
            string hash = Crypto.HashPassword(user.Password);
            user.Password = hash;
            _context.Add(user);
            await _context.SaveChangesAsync();
        }

    }
    public async Task<User> LoginAsync(string Email, string pass)
    {
        var has = await _context.User.AnyAsync(x => x.Email == Email);
        if (!has) return null;
        var user = await _context.User.Include(on => on.MySkills).Include(ob => ob.MyCompany).Include(ob => ob.ServicesDone).FirstOrDefaultAsync(u => u.Email == Email) ?? new User();
        var passCheck = Crypto.VerifyHashedPassword(user.Password, pass);
        if (user == null || !passCheck) return null;
        return user;
    }
    // public async Task LogoutAsync(){

    // }
    public async Task<User> GetUserAsync(int userId)
    {
        var user = await _context.User.FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null) return null;
        return user;
    }

}