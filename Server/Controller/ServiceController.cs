using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;

class ServiceController : ControllerBase
{
    private readonly ServiceServices? _serviceService = new();
    public async Task CreateDDS(Service service)
    {
        if (service == null || _serviceService == null) return;
        await _serviceService.CreateService(service);
    }
}