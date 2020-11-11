using LegacyData.Models.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.DataInitialization
{
    public static class Data
    {
        public static IList<PassportInactiveAllData> GetPassportInactiveAllDatas() => new List<PassportInactiveAllData>
        {
            new PassportInactiveAllData
            {
                Id = 1,
                Email = "test@test.com",
                SupervisorName="tim patton",
                UserFirstName="Joe",
                UserLastName="Smith",
                Am = "Am1",
                An ="An1",
                Comments = "Here is a set of test comments about the performance of this HOMEBOI",
                CompletionDate = DateTime.Now.ToShortDateString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = "900",
                EmployeeLegacyIndicator = "Legacy something indicative",
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = "1234",
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = "3",
                EntityId = "21",
                EntityTitle = "Employee",
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = "Neil deGrasse Tyson",
                JobLocation = "Enon, OH",
                ScheduledOfferingId = "666",
                SuperEmail = "tim.patton@speedway.com",
                TotalHours = "80000",
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = "100123",
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = DateTime.Now.AddMonths(-9).ToShortDateString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = "Org2",
                UserOrgLevel3 = "Org3",
                UserOrgLevel4 = "Org4",
                UserOrgLevel5 = "Org5",
                UserOrgLevel6 = "Org6",
                UserOrgLevel7 = "Org7",
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData{Id = 2, Email = "test2@test.com", SupervisorName="jim patton", UserFirstName="John", UserLastName="Smith" },
            new PassportInactiveAllData{Id = 3, Email = "test3@test.com", SupervisorName="bob patton", UserFirstName="John", UserLastName="Werbenjensen" },
            new PassportInactiveAllData{Id = 4, Email = "test3@test.com", SupervisorName="bob patton", UserFirstName="Joey", UserLastName="Schmodiggle" }
        };

        public static IList<VTAInactiveAllData> GetVTAInactiveAllDatas() => new List<VTAInactiveAllData>
        {
            new VTAInactiveAllData{ Id = 1, emp_id="12345", date_hire=DateTime.Now.ToShortDateString() },
            new VTAInactiveAllData{ Id = 2, emp_id="12346", date_hire=DateTime.Now.ToShortDateString() },
            new VTAInactiveAllData
            {
                Id = 3,
                emp_id="123478",
                date_hire=DateTime.Now.ToShortDateString(),
                badge_scan="true",
                bin_crse_k="bin crse k1",
                calc_cdate="calccdate1",
                cert_no="12345",
                code="code1",
                comp_date=DateTime.Now.AddMonths(-6).ToShortDateString(),
                crse_grade="A++",
                crse_score="110%",
                crse_site="Moscow, Russian Federation, Russia",
                crse_title="Communism 101",
                department="IT",
                emp_group="App Dev",
                emp_key="key12343",
                end_date=DateTime.Now.AddMonths(6).ToShortDateString(),
                firstname="RickyDibble",
                job_title="Developer",
                lastname="boPeep",
                m_init="J",
                no_complet="no complet 1",
                no_lessons="no lessons 1",
                position="1st place all day baby",
                rptkey="rptkey1",
                sess_date=DateTime.Now.AddYears(-20).ToShortDateString(),
                sess_hrs="40",
                sess_key="sesskey1",
                sess_num="sessnum1",
                sess_stat="sessstat1",
                shift="3rd Shift",
                status="Active",
                train_hrs="9001",
                workarea="next to the window :("

            },
        };

        public static IList<TestNewClass> GetNewTestClasses() => new List<TestNewClass>
        {
            new TestNewClass{ Id = 1, DateOfBirth = DateTimeOffset.Now, Name = "John" },
            new TestNewClass{ Id = 2, DateOfBirth = DateTimeOffset.Now.AddDays(-1), Name = "Joe" },
            new TestNewClass{ Id = 3, DateOfBirth = DateTimeOffset.Now.AddDays(-2), Name = "Bob" },
        };
    }
}
