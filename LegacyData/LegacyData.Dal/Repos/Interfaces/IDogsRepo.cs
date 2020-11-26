using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos.Interfaces
{
    public interface IDogsRepo : IRepo<Dogs>
    {
        public Task<Dogs> GetDogById(int id);
    }
}
