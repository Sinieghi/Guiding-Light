using GuidingLight.Model;
using GuidingLight.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLight.Controller;
class PMOCController : ControllerBase
{
    private readonly PMOCServices? _pmocService = new();
    public async Task CreateDDS(PMOC pmoc)
    {
        if (pmoc == null || _pmocService == null) return;
        await _pmocService.CreatePMOCAsync(pmoc);
    }
}