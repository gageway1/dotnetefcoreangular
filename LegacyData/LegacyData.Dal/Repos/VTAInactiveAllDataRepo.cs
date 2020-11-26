using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Repos.Interfaces;
using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    public class VTAInactiveAllDataRepo : RepoBase<VTAInactiveAllData>, IVTAInactiveAllDataRepo
    {
        public VTAInactiveAllDataRepo(LegacyDataContext context) : base(context)
        {
        }

        public async Task<List<VTAInactiveAllData>> GetVtaInactiveAllDataListByEmployeeIdAsync(int id)
        {
            var q = Table.AsQueryable();
            List<VTAInactiveAllData> vtaList = new List<VTAInactiveAllData>();
            q = q.Where(x => x.emp_id == id.ToString());
            var result = q.ToListAsync();
            return await result;
        }

        public async Task<List<VTAInactiveAllData>> GetVtaInactiveAllDataListByNameAsync(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                return new List<VTAInactiveAllData>();
            }

            var q = Table.AsQueryable();
            if (!string.IsNullOrEmpty(firstName))
            {
                q = q.Where(x => x.firstname == firstName);
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                q = q.Where(x => x.lastname == lastName);
            }
            var result = q.ToListAsync();
            return await result;
        }

        public async Task<VTAInactiveAllData> GetVtaFullEntryByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }
    }
}
