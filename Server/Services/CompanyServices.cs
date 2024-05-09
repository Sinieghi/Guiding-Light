using GuidingLight.Model;
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
    public async Task<Company> GetCompany(Company companyRef)
    {
        var company = await _context.FindAsync<Company>(companyRef);
        if (company == null) return null;
        return company;
    }

}