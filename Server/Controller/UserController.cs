using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;

class UserController : ControllerBase
{

    private readonly UserServices? _userService;

    public Task<Company> GetCompanyAsync(int id)
    {
        _userService.
    }

}