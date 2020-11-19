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

        public async Task<List<PassportInactiveAllData>> GetPassportInactiveAllDataByIdAsync(int id)
        {
            var q = Table.AsQueryable();
            List<PassportInactiveAllData> vtaList = new List<PassportInactiveAllData>();
            q = q.Where(x => x.UserId == id.ToString());
            var result = q.ToListAsync();
            return await result;

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
            var result = q.ToListAsync();
            return await result;
        }

        public async Task<PassportInactiveAllData> GetPassportFullEntryByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }
    }
}
