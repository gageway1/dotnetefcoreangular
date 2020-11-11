using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegacyData.Dal.Repos;
using LegacyData.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LegacyData.Controllers
{
    [ApiController]
    public class PassportInactiveAllDataController : ControllerBase
    {
        private readonly ILogger<PassportInactiveAllDataController> _logger;
        private readonly IPassportInactiveAllDataRepo _iPassportInactiveAllDataRepo;

        public PassportInactiveAllDataController(ILogger<PassportInactiveAllDataController> logger, IPassportInactiveAllDataRepo iPassportInactiveAllDataRepo)
        {
            _logger = logger;
            _iPassportInactiveAllDataRepo = iPassportInactiveAllDataRepo;
        }

        [HttpGet("api/passportInactiveAllDataById")]
        public async Task<IActionResult> GetPassportInactiveAllDataById(int id)
        {
            return new OkObjectResult(await _iPassportInactiveAllDataRepo.GetPassportInactiveAllDataByIdAsync(id));
        }

        [HttpGet("api/passportInactiveAllDataByName")]
        public async Task<IActionResult> GetPassportInactiveAllDataByName(string firstName, string lastName)
        {
            return new OkObjectResult(await _iPassportInactiveAllDataRepo.GetPassportInactiveAllDataByNameAsync(firstName, lastName));
        }
    }
}
