using GuidingLight.Model;
using Name;

namespace GuidingLight.Services;

class ServiceServices
{
    private readonly GuidingLightContext? _context;
    public async Task CreateService(Service service)
    {
        _context.Database.EnsureCreated();
        _context.Add(service);
        await _context.SaveChangesAsync();
    }
}