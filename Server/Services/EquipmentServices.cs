using GuidingLight.Model;
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

}