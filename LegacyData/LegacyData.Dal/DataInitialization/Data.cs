using LegacyData.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.DataInitialization
{
    public static class Data
    {
        public static IList<PassportInactiveAllData> GetPassportInactiveAllDatas() => new List<PassportInactiveAllData>
        {
            new PassportInactiveAllData{Id = 1, Email = "test@test.com", SupervisorName="tim patton" },
            new PassportInactiveAllData{Id = 2, Email = "test2@test.com", SupervisorName="jim patton" },
            new PassportInactiveAllData{Id = 3, Email = "test3@test.com", SupervisorName="bob patton" }
        };

        public static IList<VTAInactiveAllData> GetVTAInactiveAllDatas() => new List<VTAInactiveAllData>
        {
            new VTAInactiveAllData{ Id = 1, emp_id="12345", date_hire=DateTime.Now.ToShortDateString() },
            new VTAInactiveAllData{ Id = 2, emp_id="12346", date_hire=DateTime.Now.ToShortDateString() },
            new VTAInactiveAllData{ Id = 3, emp_id="123478", date_hire=DateTime.Now.ToShortDateString() },
        };

        public static IList<TestNewClass> GetNewTestClasses() => new List<TestNewClass>
        {
            new TestNewClass{ Id = 1, DateOfBirth = DateTimeOffset.Now, Name = "John" },
            new TestNewClass{ Id = 2, DateOfBirth = DateTimeOffset.Now.AddDays(-1), Name = "Joe" },
            new TestNewClass{ Id = 3, DateOfBirth = DateTimeOffset.Now.AddDays(-2), Name = "Bob" },
        };
    }
}
