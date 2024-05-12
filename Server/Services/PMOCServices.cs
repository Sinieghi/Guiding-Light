using GuidingLight.Model;
using Name;

namespace GuidingLight.Services;

class PMOCServices
{
    private readonly GuidingLightContext? _context;
    public async Task CreatePMOCAsync(PMOC mOC)
    {
        if (mOC == null || _context == null) return;
        await _context.Database.EnsureCreatedAsync();
        _context.Add(mOC);
        await _context.SaveChangesAsync();
    }
}