using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;
using Name;

namespace GuidingLight.Services;

class EquipmentServices
{
    private readonly GuidingLightContext? _context = new();

    public async Task CreateEquipment(Equipment equipment)
    {
        await _context.Database.EnsureCreatedAsync();
        await _context.Equipment.AddAsync(equipment);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEquipment(Equipment equipment) { await _context.Equipment.Where(x => x.Id == equipment.Id).ExecuteDeleteAsync(); }

    public async Task<List<Equipment>> GetEquipment(Company company)
    {
        if (await _context.Equipment.AnyAsync(x => x.CompanyRef == company))
            return await _context.Equipment.Where(x => x.CompanyRef == company).ToListAsync();
        return null;
    }
}