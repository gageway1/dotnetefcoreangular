using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Repos;
using LegacyData.Models.Models;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;

namespace LegacyData.Test
{

    [Collection("LegacyDataTests")]
    public class TestNewClassTest : IDisposable
    {
        private TestNewClassRepo _testNewClassRepo;
        public TestNewClassTest()
        {
            _testNewClassRepo = new TestNewClassRepo(new LegacyDataContextFactory().CreateDbContext(new string[] { }));
        }

        public void Dispose()
        {
            _testNewClassRepo?.Dispose();
        }

        [Fact]
        public void ShouldNotReturnData()
        {
            var results = _testNewClassRepo.Table.ToList();
            Assert.NotEmpty(results);
        }

        [Fact]
        public void ShouldReturnTestData()
        {
            var testNewClass = new TestNewClass
            {
                DateOfBirth = DateTimeOffset.Now.AddMonths(-6),
                Name = "Jimmybob"
            };
            _testNewClassRepo.Add(testNewClass);
            _testNewClassRepo.SaveChanges();

            Assert.True(testNewClass.Id != 0);
            Assert.Equal("Jimmybob", testNewClass.Name);
        }
    }
}
