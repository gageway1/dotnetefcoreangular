using LegacyData.Models.Models;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    public interface ITestNewClassRepo
    {
        Task<TestNewClass> GetTestClassById(int id);
    }
}