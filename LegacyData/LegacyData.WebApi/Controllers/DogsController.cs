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
    public class DogsController : ControllerBase
    {
        //THIS IS HOW YOUR CONTROLLER SHOULD LOOK
        private readonly ILogger<DogsController> _logger;
        private readonly IDogsRepo _iDogsRepo;

        public DogsController(ILogger<DogsController> logger, IDogsRepo iDogsRepo)
        {
            _logger = logger;
            _iDogsRepo = iDogsRepo;
        }

        [HttpGet("api/getDogById")] // GET || POST || PUT | "Edit old object" || DELETE
        public async Task<IActionResult> GetDogById(int id)
        {
            return new OkObjectResult(await _iDogsRepo.GetDogById(id));
        }
    }
}
