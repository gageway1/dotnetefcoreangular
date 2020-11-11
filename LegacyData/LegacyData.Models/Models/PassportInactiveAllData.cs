using LegacyData.Models.Models.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LegacyData.Models.Models
{
    [Table("CP01PassportInactiveAllData", Schema = "LegacyData")]
    public class PassportInactiveAllData : EntityBase
    {
        public string UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserMiddleInitial { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string EntityTitle { get; set; }
        public string CompletionDate { get; set; }
        public string CompletionStatus { get; set; }
        public string Grade { get; set; }
        public string CreditHours { get; set; }
        public string TotalHours { get; set; }
        public string EntityAssignmentType { get; set; }
        public string ScheduledOfferingId { get; set; }
        public string Instructor { get; set; }
        public string Comments { get; set; }
        public string UserDomain { get; set; }
        public string UserStatus { get; set; }
        public string UserJobTitle { get; set; }
        public string UserJobTitleDate { get; set; }
        public string UserDepartment { get; set; }
        public string UserOrgLevel2 { get; set; }
        public string UserOrgLevel3 { get; set; }
        public string UserOrgLevel4 { get; set; }
        public string UserOrgLevel5 { get; set; }
        public string UserOrgLevel6 { get; set; }
        public string UserOrgLevel7 { get; set; }
        public string EmployeeTypeId { get; set; }
        public string EmployeeSubgroup { get; set; }
        public string EmployeeStatusId { get; set; }
        public string Costcenter { get; set; }
        public string Email { get; set; }
        public string SupervisorName { get; set; }
        public string SuperEmail { get; set; }
        public string JobLocation { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedAt { get; set; }
        public string EmployeeLegacyIndicator { get; set; }
        public string EmployeeLearningJobTitle { get; set; }
        public string Am { get; set; }
        public string An { get; set; }
    }
}
