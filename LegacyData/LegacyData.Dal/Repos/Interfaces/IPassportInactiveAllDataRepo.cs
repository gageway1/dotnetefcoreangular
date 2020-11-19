using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    public interface IPassportInactiveAllDataRepo : IRepo<PassportInactiveAllData>
    {
        Task<List<PassportInactiveAllData>> GetPassportInactiveAllDataByIdAsync(int id);
        Task<List<PassportInactiveAllData>> GetPassportInactiveAllDataByNameAsync(string firstName, string lastName);
        Task<PassportInactiveAllData> GetPassportFullEntryByIdAsync(int id);
    }
}