using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;
using Name;

namespace GuidingLight.Services;

class CompanyServices
{
    private readonly GuidingLightContext? _context;

    public async Task CreateCompany(Company company)
    {
        _context.Database.EnsureCreated();
        _context.Add(company);
        await _context.SaveChangesAsync();
    }
    public async Task<Company> GetCompany(int companyRef)
    {
        var company = await _context.Company
        .Where(x => x.Id == companyRef).Include(u => u.WorkersRole)
        .Include(u => u.Workers).Include(u => u.DDs)
        .Include(u => u.OSList).Include(u => u.PMOCs)
        .Include(u => u.PMOCs).FirstOrDefaultAsync();
        if (company == null) return null;
        return company;
    }
    public async Task<User> GetOwnerAsync(int id)
    {
        var user = await _context.User.AnyAsync(x => x.Id == id);
        if (user == null) return null;
        var owner = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
        return owner;
    }
    public async Task<List<Company>> GetWorkersAsync(int[] ids)
    {
        var workers = await _context.Company.Include(u => u.Workers).ToListAsync();
        return workers;
    }

}