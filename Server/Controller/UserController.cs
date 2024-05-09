using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;

class UserController : ControllerBase
{

    private readonly UserServices? _userService = new();

    // public Task<Company> GetCompanyAsync(int id)
    // {
    //     _userService.
    // }

    public Task<User> LoginAsync(string Email, string Password)
    {
        return _userService.LoginAsync(Email, Password);
    }

    public async Task CreateAsync(User user)
    {
        await _userService.CreateUserAsync(user);
    }

}