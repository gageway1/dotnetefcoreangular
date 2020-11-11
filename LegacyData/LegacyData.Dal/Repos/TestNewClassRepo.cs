using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Repos.Interfaces.Base;
using LegacyData.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos
{
    //INHERIT FROM REPOBASE<YOURCLASS>, YOUR ICLASSREPO
    public class TestNewClassRepo : RepoBase<TestNewClass>, ITestNewClassRepo
    {
        public TestNewClassRepo(LegacyDataContext context) : base(context)
        {
        }

        /*This is where you write code to do things you need!*/
        public async Task<TestNewClass> GetTestClassById(int id)
        {
            return await Table.FindAsync(id);
        }
    }
}
