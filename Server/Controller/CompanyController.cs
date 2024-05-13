using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;

class CompanyController : ControllerBase
{

    private readonly CompanyServices? _companyService = new();

    public async Task<Company> CompanyUsers(int companyId)
    {
        return await _companyService.GetCompany(companyId);
    }
    public async Task CreateCompany(Company company)
    {
        if (company == null) return;
        await _companyService.CreateCompany(company);
    }
}