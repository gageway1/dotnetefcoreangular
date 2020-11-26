using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Repos.Interfaces;
using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    public class DogsRepo : RepoBase<Dogs>, IDogsRepo
    {
        public DogsRepo(LegacyDataContext context) : base(context)
        {
        }

        public async Task<Dogs> GetDogById(int id)
        {
            return await Table.FindAsync(id);
        }
    }
}
