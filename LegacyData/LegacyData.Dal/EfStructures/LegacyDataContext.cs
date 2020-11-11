using LegacyData.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.EfStructures
{
    public class LegacyDataContext : DbContext
    {
        public LegacyDataContext(DbContextOptions<LegacyDataContext> options)
            : base(options)
        {

        }

        public DbSet<PassportInactiveAllData> PassportInactiveAllDatas { get; set; }
        public DbSet<VTAInactiveAllData> VTAInactiveAllDatas { get; set; }
        //README Put new classes in here to be added to the database
        public DbSet<TestNewClass> TestNewClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassportInactiveAllData>(entity =>
            {
                entity.ToTable("CP01PassportInactiveAllData");

                entity.Property(e => e.Am)
                    .HasColumnName("AM")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.An)
                    .HasColumnName("AN")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CompletionDate)
                    .HasColumnName("COMPLETION DATE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompletionStatus)
                    .HasColumnName("COMPLETION STATUS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Costcenter)
                    .HasColumnName("COSTCENTER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreditHours)
                    .HasColumnName("CREDIT HOURS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLearningJobTitle)
                    .HasColumnName("EMPLOYEE LEARNING JOB TITLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLegacyIndicator)
                    .HasColumnName("EMPLOYEE LEGACY INDICATOR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusId)
                    .HasColumnName("EMPLOYEE STATUS ID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeSubgroup)
                    .HasColumnName("EMPLOYEE SUBGROUP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeId)
                    .HasColumnName("EMPLOYEE TYPE ID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntityAssignmentType)
                    .HasColumnName("ENTITY ASSIGNMENT TYPE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId)
                    .HasColumnName("ENTITY ID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntityTitle)
                    .HasColumnName("ENTITY TITLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasColumnName("ENTITY TYPE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Instructor)
                    .HasColumnName("INSTRUCTOR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobLocation)
                    .HasColumnName("JOB LOCATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedAt)
                    .HasColumnName("LAST UPDATED AT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST UPDATED BY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledOfferingId)
                    .HasColumnName("SCHEDULED OFFERING ID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SuperEmail)
                    .HasColumnName("SUPER EMAIL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorName)
                    .HasColumnName("SUPERVISOR NAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalHours)
                    .HasColumnName("TOTAL HOURS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserDepartment)
                    .HasColumnName("USER DEPARTMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserDomain)
                    .HasColumnName("USER DOMAIN")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstName)
                    .HasColumnName("USER FIRST NAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER ID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserJobTitle)
                    .HasColumnName("USER JOB TITLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserJobTitleDate)
                    .HasColumnName("USER JOB TITLE DATE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .HasColumnName("USER LAST NAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserMiddleInitial)
                    .HasColumnName("USER MIDDLE INITIAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserOrgLevel2)
                    .HasColumnName("USER ORG LEVEL 2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserOrgLevel3)
                    .HasColumnName("USER ORG LEVEL 3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserOrgLevel4)
                    .HasColumnName("USER ORG LEVEL 4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserOrgLevel5)
                    .HasColumnName("USER ORG LEVEL 5")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserOrgLevel6)
                    .HasColumnName("USER ORG LEVEL 6")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserOrgLevel7)
                    .HasColumnName("USER ORG LEVEL 7")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatus)
                    .HasColumnName("USER STATUS")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            //modelBuilder.Entity<PassportInactiveAllData>(entity =>
            //{
            //    entity.ToTable("CP01VTAInactiveAllData");

            //    entity.Property(e => e.BadgeScan)
            //        .HasColumnName("badge_scan")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.BinCrseK)
            //        .HasColumnName("bin_crse_k")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CalcCdate)
            //        .HasColumnName("calc_cdate")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CertNo)
            //        .HasColumnName("cert_no")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Code)
            //        .HasColumnName("code")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CompDate)
            //        .HasColumnName("comp_date")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CrseGrade)
            //        .HasColumnName("crse_grade")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CrseScore)
            //        .HasColumnName("crse_score")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CrseSite)
            //        .HasColumnName("crse_site")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CrseTitle)
            //        .HasColumnName("crse_title")
            //        .HasMaxLength(150)
            //        .IsUnicode(false);

            //    entity.Property(e => e.DateHire)
            //        .HasColumnName("date_hire")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Department)
            //        .HasColumnName("department")
            //        .HasMaxLength(150)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmpGroup)
            //        .HasColumnName("emp_group")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmpId)
            //        .HasColumnName("emp_id")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmpKey)
            //        .HasColumnName("emp_key")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EndDate)
            //        .HasColumnName("end_date")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Firstname)
            //        .HasColumnName("firstname")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.JobTitle)
            //        .HasColumnName("job_title")
            //        .HasMaxLength(150)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Lastname)
            //        .HasColumnName("lastname")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.MInit)
            //        .HasColumnName("m_init")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.NoComplet)
            //        .HasColumnName("no_complet")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.NoLessons)
            //        .HasColumnName("no_lessons")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Position)
            //        .HasColumnName("position")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Rptkey)
            //        .HasColumnName("rptkey")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SessDate)
            //        .HasColumnName("sess_date")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SessHrs)
            //        .HasColumnName("sess_hrs")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SessKey)
            //        .HasColumnName("sess_key")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SessNum)
            //        .HasColumnName("sess_num")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SessStat)
            //        .HasColumnName("sess_stat")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Shift)
            //        .HasColumnName("shift")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Status)
            //        .HasColumnName("status")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.TrainHrs)
            //        .HasColumnName("train_hrs")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Workarea)
            //        .HasColumnName("workarea")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

        }


    }
}
