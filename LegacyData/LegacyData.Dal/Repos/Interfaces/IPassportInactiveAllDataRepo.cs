using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    public interface IPassportInactiveAllDataRepo : IRepo<PassportInactiveAllData>
    {
        Task<PassportInactiveAllData> GetPassportInactiveAllDataByIdAsync(int id);
        Task<List<PassportInactiveAllData>> GetPassportInactiveAllDataByName(string firstName, string lastName);
    }
}