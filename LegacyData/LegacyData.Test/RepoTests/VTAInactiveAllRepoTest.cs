using LegacyData.Dal.EfStructures;
using LegacyData.Dal.Repos;
using LegacyData.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LegacyData.Test.RepoTests
{
    [Collection("LegacyDataTests")]
    public class VTAInactiveAllRepoTest : IDisposable
    {
        private VTAInactiveAllDataRepo _vtaInactiveAllDataRepo;
        public VTAInactiveAllRepoTest()
        {
            _vtaInactiveAllDataRepo = new VTAInactiveAllDataRepo(new LegacyDataContextFactory().CreateDbContext(new string[] { }));
        }

        public void Dispose()
        {
            _vtaInactiveAllDataRepo?.Dispose();
        }

        [Fact]
        public void ShouldNotReturnData()
        {
            var results = _vtaInactiveAllDataRepo.Table.ToList();
            Assert.NotEmpty(results);
        }

        [Fact]
        public void ShouldReturnTestData()
        {
            var vtaInactiveAllData = new VTAInactiveAllData
            {
                firstname = "joe",
                lastname = "smith"
            };
            _vtaInactiveAllDataRepo.Add(vtaInactiveAllData);
            _vtaInactiveAllDataRepo.SaveChanges();

            Assert.True(vtaInactiveAllData.Id != 0);
            Assert.Equal("joe", vtaInactiveAllData.firstname);
            Assert.Equal("smith", vtaInactiveAllData.lastname);
        }

        [Theory]
        [InlineData("Joe", "Smith")]
        [InlineData("joe", "smith")]
        public async void ShouldBeCaseInsensitive(string firstName, string lastName)
        {
            var result = await _vtaInactiveAllDataRepo.GetVtaInactiveAllDataListByNameAsync(firstName, lastName);
            Assert.Single(result);
        }
    }
}
