using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GuidingLight.Controller;

class CompanyController : ControllerBase
{

    private readonly CompanyServices? _companyService;

    public async Task<Company> CompanyUsers(int companyId)
    {
        // if (_companyService == null) return StatusCode( StatusCodes.Status500InternalServerError = 500);
        return await _companyService.GetCompany(companyId);
    }
    public async Task CreateCompany(Company company)
    {
        if (company == null) return;
        await _companyService.CreateCompany(company);
    }
}