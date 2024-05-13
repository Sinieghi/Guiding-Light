using GuidingLight.Model;
using Name;

namespace GuidingLight.Services;

class OSServices
{
    private readonly GuidingLightContext? _context;
    public async Task CreateOSAsync(OS os)
    {
        if (os == null || _context == null) return;
        await _context.Database.EnsureCreatedAsync();
        _context.Add(os);
        await _context.SaveChangesAsync();
    }
}