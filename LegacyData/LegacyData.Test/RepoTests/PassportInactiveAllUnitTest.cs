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
    public class PassportInactiveAllUnitTest : IDisposable
    {
        private PassportInactiveAllDataRepo _passportInactiveAllDataRepo;
        public PassportInactiveAllUnitTest()
        {
            _passportInactiveAllDataRepo = new PassportInactiveAllDataRepo(new LegacyDataContextFactory().CreateDbContext(new string[] { }));
        }

        public void Dispose()
        {
            _passportInactiveAllDataRepo?.Dispose();
        }

        [Fact]
        public void ShouldNotReturnData()
        {
            var results = _passportInactiveAllDataRepo.Table.ToList();
            Assert.NotEmpty(results);
        }

        [Fact]
        public void ShouldReturnTestData()
        {
            var passportInactiveAllData = new PassportInactiveAllData
            {
                Email = "test@gmail.com",
                An = "test?",
            };
            _passportInactiveAllDataRepo.Add(passportInactiveAllData);
            _passportInactiveAllDataRepo.SaveChanges();

            Assert.True(passportInactiveAllData.Id != 0);
            Assert.Equal("test@gmail.com", passportInactiveAllData.Email);
            Assert.Equal("test?", passportInactiveAllData.An);
        }

        [Theory]
        [InlineData("Joe", "Smith")]
        [InlineData("joe", "smith")]
        public async void ShouldBeCaseInsensitive(string firstName, string lastName)
        {
            var result = await _passportInactiveAllDataRepo.GetPassportInactiveAllDataListByNameAsync(firstName, lastName);
            Assert.Single(result);
        }
    }
}
