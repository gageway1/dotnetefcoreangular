﻿using System;
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
    public class TestNewClassController : ControllerBase
    {
        private readonly ILogger<TestNewClassController> _logger;
        private readonly ITestNewClassRepo _iTestNewClassRepo;

        public TestNewClassController(ILogger<TestNewClassController> logger, ITestNewClassRepo iTestNewClassRepo)
        {
            _logger = logger;
            _iTestNewClassRepo = iTestNewClassRepo;
        }

        [HttpGet("api/passportInactiveAllDataById")]
        public async Task<IActionResult> GetPassportInactiveAllDataById(int id)
        {
            return new OkObjectResult(await _iTestNewClassRepo.GetTestClassById(id));
        }
    }
}
