using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    /*Create your interface, you can right click your repo class name and "Extract interface"
      Make sure it's in this folder. */
    public interface ITestNewClassRepo : IRepo<TestNewClass> //Inherit from IRepo<YourClass>
    {
        Task<TestNewClass> GetTestClassById(int id);
    }
}