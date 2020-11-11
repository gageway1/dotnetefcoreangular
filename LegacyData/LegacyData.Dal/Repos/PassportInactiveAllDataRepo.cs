using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    public class PassportInactiveAllDataRepo : RepoBase<PassportInactiveAllData>, IPassportInactiveAllDataRepo
    {
        public PassportInactiveAllDataRepo(LegacyDataContext context) : base(context)
        {
        }

        public async Task<PassportInactiveAllData> GetPassportInactiveAllDataByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<List<PassportInactiveAllData>> GetPassportInactiveAllDataByName(string firstName, string lastName)
        {
            return await Table.Where(p => p.UserFirstName == firstName && p.UserLastName == lastName).ToListAsync();
        }
    }
}
