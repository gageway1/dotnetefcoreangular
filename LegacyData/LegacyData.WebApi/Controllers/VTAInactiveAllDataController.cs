using LegacyData.Dal.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegacyData.Portal.Controllers
{
    [ApiController]
    public class VTAInactiveAllDataController : ControllerBase
    {
        private readonly ILogger<VTAInactiveAllDataController> _logger;
        private readonly IVTAInactiveAllDataRepo _iVTAInactiveAllDataRepo;

        public VTAInactiveAllDataController(ILogger<VTAInactiveAllDataController> logger, IVTAInactiveAllDataRepo iVTAInactiveAllDataRepo)
        {
            _logger = logger;
            _iVTAInactiveAllDataRepo = iVTAInactiveAllDataRepo;
        }

        [HttpGet("api/getVtaInactiveAllDataById")]
        public async Task<IActionResult> GetVtaInactiveById(int id)
        {
            return new OkObjectResult(await _iVTAInactiveAllDataRepo.GetVtaInactiveAllDataListByEmployeeIdAsync(id));
        }

        [HttpGet("api/getVtaInactiveAllDataByName")]
        public async Task<IActionResult> GetVTAInactiveByName(string firstName, string lastName)
        {
            return new OkObjectResult(await _iVTAInactiveAllDataRepo.GetVtaInactiveAllDataListByNameAsync(firstName, lastName));
        }

        [HttpGet("api/getVtaInactiveFullEntryById")]
        public async Task<IActionResult> GetVtaFullEntryById(int id)
        {
            return new OkObjectResult(await _iVTAInactiveAllDataRepo.GetVtaFullEntryByIdAsync(id));
        }

    }
}
