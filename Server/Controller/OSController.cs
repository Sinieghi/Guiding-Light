using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;

class OSController : ControllerBase
{
    private readonly OSServices? _osService = new();
    public async Task CreateDDS(OS os)
    {
        if (os == null || _osService == null) return;
        await _osService.CreateOSAsync(os);
    }
}