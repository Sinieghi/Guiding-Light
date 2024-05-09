using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GuidingLight.Controller;

class CompanyController : ControllerBase
{

    private readonly CompanyServices? _companyService;

    public Task CompanyUsers(Company company)
    {
        // if (_companyService == null) return StatusCode( StatusCodes.Status500InternalServerError = 500);
        return _companyService.GetCompany(company);
    }
}