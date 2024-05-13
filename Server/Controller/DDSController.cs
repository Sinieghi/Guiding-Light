using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;

class DDSController : ControllerBase
{
    private readonly DDSServices? _ddsService = new();
    public async Task CreateDDS(DDS dds)
    {
        if (dds == null || _ddsService == null) return;
        await _ddsService.CreateDDSAsync(dds);
    }
}