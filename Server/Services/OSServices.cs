using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;
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
    public async Task DeleteOS(OS oS)
    {
        if (oS == null || _context == null) return;
        await _context.OS.Where(x => x.Id == oS.Id).ExecuteDeleteAsync();
    }
    public async Task<List<OS>> GetOSs(Company company)
    {
        if (_context == null) return null;
        return await _context.OS.Where(x => x.Company == company).ToListAsync();
    }
    public async Task UpdateOs(OS oS)
    {
        if (oS == null || _context == null) return;
        var os = await _context.OS.Where(x => x.Id == oS.Id).FirstOrDefaultAsync();
        if (oS == null) return;
        os = oS;
        await _context.SaveChangesAsync();
    }
}