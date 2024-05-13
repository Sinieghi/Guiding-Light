using GuidingLight.Model;
using Name;

namespace GuidingLight.Services;

class DDSServices
{
    private readonly GuidingLightContext? _context;
    public async Task CreateDDSAsync(DDS dds)
    {
        if (dds == null || _context == null) return;
        await _context.Database.EnsureCreatedAsync();
        _context.Add(dds);
        await _context.SaveChangesAsync();
    }
}