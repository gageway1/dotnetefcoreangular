﻿using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos.Interfaces
{
    public interface IVTAInactiveAllDataRepo : IRepo<VTAInactiveAllData>
    {
        Task<List<VTAInactiveAllData>> GetVtaInactiveAllDataListByEmployeeIdAsync(int id);
        Task<List<VTAInactiveAllData>> GetVtaInactiveAllDataListByNameAsync(string firstName, string lastName);
        Task<VTAInactiveAllData> GetVtaFullEntryByIdAsync(int id);
    }
}
