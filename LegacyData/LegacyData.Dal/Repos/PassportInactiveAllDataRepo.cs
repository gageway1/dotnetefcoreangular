using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Exceptions;
using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
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

        public async Task<List<PassportInactiveAllData>> GetPassportInactiveAllDataByNameAsync(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                return new List<PassportInactiveAllData>();
            }

            var q = Table.AsQueryable();
            if (!string.IsNullOrEmpty(firstName))
            {
                q = q.Where(x => x.UserFirstName == firstName);
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                q = q.Where(x => x.UserLastName == lastName);
            }

            return await q.ToListAsync();
        }
    }
}
