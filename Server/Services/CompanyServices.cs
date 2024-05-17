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
    public async Task UpdateCompany(Company company)
    {
        var co = await _context.Company.Where(x => x.Id == company.Id).FirstOrDefaultAsync();
        if (co != null) return;
        _context.Update(company);
    }
    public async Task<Company> GetCompany(int companyRef)
    {
        var company = await _context.Company
        .Where(x => x.Id == companyRef).Include(i => i.Owner).FirstOrDefaultAsync();
        if (company == null) return null;
        return company;
    }
    //***** Imagine if i had a map showing the current location of workers... Would be great, i guess. I can use google map API for this
    public async Task<List<User>> GetWorkersAsync(Company company)
    {
        var user = await _context.User.AnyAsync(x => x.MyCompany == company);
        if (user == null) return null;
        var workers = await _context.User.Where(x => x.MyCompany == company).ToListAsync();
        return workers;
    }
    public async Task<List<Service>> GetServicesAsync(Company company)
    {
        var Has = await _context.Service.AnyAsync(x => x.Company == company);
        if (Has == null) return null;
        var services = await _context.Service.Where(x => x.Company == company).ToListAsync();
        return services;
    }
    public async Task DisbandCompanyAsync(Company company)
    {
        if (company == null || _context == null) return;
        await _context.Company
        .Where(x => x.Id == company.Id).ExecuteDeleteAsync();
    }


}