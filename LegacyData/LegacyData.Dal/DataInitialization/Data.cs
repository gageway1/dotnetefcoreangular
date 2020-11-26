using LegacyData.Models.Models;
using System;
using System.Collections.Generic;

namespace LegacyData.Dal.DataInitialization
{
    public static class Data
    {
        public static IList<Dogs> GetDogs()
        {
            List<Dogs> dogList = new List<Dogs>()
            {
                new Dogs
                {
                    AgeInYears = 8,
                    CheckingAccountAmount = 1234m,
                    FirstName = "John",
                    MiddleInit = 'F',
                    LastName = "Josephine",
                    Id = 1,
                    LocationX = 100.000f,
                    LocationY = 200.025f
                },
                new Dogs
                {
                    AgeInYears = 10,
                    CheckingAccountAmount = 3124891.5893m,
                    FirstName = "Joe",
                    MiddleInit = 'M',
                    LastName = "Herbert",
                    Id = 2,
                    LocationX = 105.000f,
                    LocationY = 205.025f
                },
            };
            return dogList;
        }

        public static IList<PassportInactiveAllData> GetPassportInactiveAllDatas()
        {
            List<string> firstNames = new List<string>();
            firstNames.Add("John");
            firstNames.Add("James");
            firstNames.Add("Jim");
            firstNames.Add("Bob");
            firstNames.Add("Joe");
            firstNames.Add("Diego");
            firstNames.Add("Paul");
            firstNames.Add("Rocky");
            List<string> lastNames = new List<string>();
            lastNames.Add("Smith");
            lastNames.Add("Johnson");
            lastNames.Add("Denver");
            lastNames.Add("Way");
            lastNames.Add("Godzilla");
            List<int> empIds = new List<int>();
            empIds.Add(12348);
            empIds.Add(12346);
            empIds.Add(1234);
            empIds.Add(12345);
            empIds.Add(12343);
            empIds.Add(12342);
            empIds.Add(12341);
            empIds.Add(12340);
            var rng = new Random();

            List<PassportInactiveAllData> passportList = new List<PassportInactiveAllData>() {
            new PassportInactiveAllData
            {
                Id = 1,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = "1234",
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData { Id = 2, Email = "test2@test.com", SupervisorName = "jim patton", UserFirstName = "John", UserLastName = "Smith", UserId = "1234", CompletionDate = new DateTimeOffset(DateTime.Now).ToString(), EntityTitle = "Intro To IT" },
            new PassportInactiveAllData { Id = 3, Email = "test3@test.com", SupervisorName = "bob patton", UserFirstName = "John", UserLastName = "Werbenjensen" },
            new PassportInactiveAllData { Id = 4, Email = "test3@test.com", SupervisorName = "bob patton", UserFirstName = "Joey", UserLastName = "Schmodiggle", UserId = "1237" },
            new PassportInactiveAllData { Id = 5, Email = "test2@test.com", SupervisorName = "jim patton", UserFirstName = "John", UserLastName = "Smith", UserId = "1234", CompletionDate = new DateTimeOffset(DateTime.Now).ToString(), EntityTitle = "Intro To Calculus" },
            new PassportInactiveAllData { Id = 6, Email = "test2@test.com", SupervisorName = "jim patton", UserFirstName = "John", UserLastName = "Smith", UserId = "1234", CompletionDate = new DateTimeOffset(DateTime.Now).ToString(), EntityTitle = "Intro To Statistics" },
            new PassportInactiveAllData
            {
                Id = 7,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 8,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 9,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 10,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 11,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 12,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 13,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 14,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 15,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            new PassportInactiveAllData
            {
                Id = 16,
                Email = rng.Next(1,5000).ToString() + "@test.com",
                SupervisorName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserFirstName = firstNames[rng.Next(firstNames.ToArray().Length)],
                UserLastName = lastNames[rng.Next(lastNames.ToArray().Length)],
                Am = "Am" + rng.Next(1,5000).ToString(),
                An = "An1" + rng.Next(1,5000).ToString(),
                Comments = "COMMENTS " + rng.Next(0, int.MaxValue-1).ToString(),
                CompletionDate = new DateTimeOffset(DateTime.Now).ToString(),
                CompletionStatus = "Completed",
                EmployeeLearningJobTitle = "Intern AF",
                Costcenter = "That cost center",
                CreditHours = rng.Next(1,5000).ToString(),
                EmployeeLegacyIndicator = "L" + rng.Next(1,5000).ToString(),
                EntityAssignmentType = "A type of assignment",
                EmployeeStatusId = rng.Next(1,5000).ToString(),
                EmployeeSubgroup = "Group of subs",
                EmployeeTypeId = rng.Next(1,5000).ToString(),
                EntityId = rng.Next(1,5000).ToString(),
                EntityTitle = "Employee " + rng.Next(1,5000).ToString(),
                EntityType = "a type of entity",
                Grade = "F--",
                Instructor = firstNames[rng.Next(firstNames.ToArray().Length)] + " " + lastNames[rng.Next(lastNames.ToArray().Length)],
                JobLocation = "Enon, OH",
                ScheduledOfferingId = rng.Next(1,5000).ToString(),
                SuperEmail = firstNames[rng.Next(firstNames.ToArray().Length)] + "_" + lastNames[rng.Next(lastNames.ToArray().Length)] + "@speedway.com",
                TotalHours = rng.Next(1,5000).ToString(),
                UserDepartment = "IT",
                UserDomain = "@jsmith",
                UserId = empIds[rng.Next(empIds.ToArray().Length)].ToString(),
                UserJobTitle = "Software Engineer",
                UserJobTitleDate = new DateTimeOffset(DateTime.Now).ToString(),
                UserMiddleInitial = "N",
                UserOrgLevel2 = rng.Next(1,5000).ToString(),
                UserOrgLevel3 = rng.Next(1,5000).ToString(),
                UserOrgLevel4 = rng.Next(1,5000).ToString(),
                UserOrgLevel5 = rng.Next(1,5000).ToString(),
                UserOrgLevel6 = rng.Next(1,5000).ToString(),
                UserOrgLevel7 = rng.Next(1,5000).ToString(),
                UserStatus = "Inactive"
            },
            };

            return passportList;
        }

        public static IList<VTAInactiveAllData> GetVTAInactiveAllDatas()
        {
            List<string> firstNames = new List<string>();
            firstNames.Add("John");
            firstNames.Add("James");
            firstNames.Add("Jim");
            firstNames.Add("Bob");
            firstNames.Add("Joe");
            firstNames.Add("Diego");
            firstNames.Add("Paul");
            firstNames.Add("Rocky");
            List<string> lastNames = new List<string>();
            lastNames.Add("Smith");
            lastNames.Add("Johnson");
            lastNames.Add("Denver");
            lastNames.Add("Way");
            lastNames.Add("Godzilla");
            List<int> empIds = new List<int>();
            empIds.Add(12348);
            empIds.Add(12346);
            empIds.Add(12347);
            empIds.Add(12345);
            empIds.Add(12343);
            empIds.Add(12342);
            empIds.Add(12341);
            empIds.Add(12340);
            var rng = new Random();

            List<VTAInactiveAllData> vtaList = new List<VTAInactiveAllData>() {
            new VTAInactiveAllData { Id = 1, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 2, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 3, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 4, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 5, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 6, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 7, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 8, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 9, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
            new VTAInactiveAllData { Id = 10, firstname = firstNames[rng.Next(firstNames.ToArray().Length)], lastname = lastNames[rng.Next(lastNames.ToArray().Length)], emp_id=empIds[rng.Next(empIds.ToArray().Length)].ToString(), date_hire=new DateTimeOffset(DateTime.Now).ToString(), badge_scan=true.ToString(), bin_crse_k=Guid.NewGuid().ToString(), calc_cdate=new DateTimeOffset(DateTime.Now).ToString(), cert_no=rng.Next(1,99999).ToString(), code="C-"+(rng.Next(1,99999)).ToString(), comp_date=new DateTimeOffset(DateTime.Now).ToString(), crse_grade="A++", crse_score=(rng.Next(40,100).ToString()) + "%", crse_site="SomePlace"+rng.Next(1,10).ToString(), crse_title="Some Class 101", department="IT", emp_group="App Dev", emp_key="K"+ rng.Next(1,99999), end_date=new DateTimeOffset(DateTime.Now.AddMonths(6)).ToString(), job_title="Developer", m_init="J", no_complet=rng.Next(1,50).ToString(), no_lessons=rng.Next(1,50).ToString(), position="Position " + rng.Next(1,50).ToString(), rptkey="R" + rng.Next(1,50).ToString(), sess_date=DateTime.Now.AddYears(-20).ToShortDateString(), sess_hrs=rng.Next(1,50).ToString(), sess_key="SK" + rng.Next(1,50).ToString(), sess_num="SN" + rng.Next(1,50).ToString(), sess_stat="SS" + rng.Next(1,50).ToString(), shift=rng.Next(1,4).ToString(), status="Active", train_hrs=rng.Next(1,1000).ToString(), workarea="Area A" +rng.Next(1,500).ToString() },
             new VTAInactiveAllData{ Id = 11, emp_id="12345", date_hire=new DateTimeOffset(DateTime.Now).ToString() },
            new VTAInactiveAllData{ Id = 12, emp_id="12346", date_hire=new DateTimeOffset(DateTime.Now).ToString() },
            new VTAInactiveAllData
            {
                Id = 13,
                emp_id="123478",
                date_hire=DateTime.Now.ToShortDateString(),
                badge_scan="true",
                bin_crse_k="bin crse k1",
                calc_cdate="calccdate1",
                cert_no="12345",
                code="code1",
                comp_date=new DateTimeOffset(DateTime.Now).ToString(),
                crse_grade="A++",
                crse_score="110%",
                crse_site="Moscow, Russian Federation, Russia",
                crse_title="Basket Weaving 101",
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
            new VTAInactiveAllData{ Id = 14, emp_id="12347", comp_date=new DateTimeOffset(DateTime.Now).ToString(), firstname="jim", lastname="jones", crse_grade="A", crse_title="Econ 101", date_hire=new DateTimeOffset().ToString() },
            new VTAInactiveAllData{ Id = 15, emp_id="12347", comp_date=new DateTimeOffset(DateTime.Now).ToString(), firstname="jim", lastname="jones", crse_grade="F", crse_title="Business 101", date_hire=new DateTimeOffset().ToString() },
            new VTAInactiveAllData{ Id = 16, emp_id="12347", comp_date=new DateTimeOffset(DateTime.Now).ToString(), firstname="jim", lastname="jones", crse_grade="B+", crse_title="Trigonomotry 101", date_hire=new DateTimeOffset().ToString() },
            };
            return vtaList;
        }

        public static IList<TestNewClass> GetNewTestClasses() => new List<TestNewClass>
        {
            new TestNewClass{ Id = 1, DateOfBirth = new DateTimeOffset(), Name = "John" },
            new TestNewClass{ Id = 2, DateOfBirth = new DateTimeOffset(), Name = "Joe" },
            new TestNewClass{ Id = 3, DateOfBirth =new DateTimeOffset(), Name = "Bob" },
        };
    }
}
