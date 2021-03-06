﻿// <auto-generated />
using System;
using LegacyData.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LegacyData.Dal.EfStructures.Migrations
{
    [DbContext(typeof(LegacyDataContext))]
    [Migration("20201111024034_AddTestNewClass")]
    partial class AddTestNewClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LegacyData.Models.Models.PassportInactiveAllData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Am")
                        .HasColumnName("AM")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("An")
                        .HasColumnName("AN")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Comments")
                        .HasColumnName("COMMENTS")
                        .HasColumnType("varchar(5000)")
                        .HasMaxLength(5000)
                        .IsUnicode(false);

                    b.Property<string>("CompletionDate")
                        .HasColumnName("COMPLETION DATE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("CompletionStatus")
                        .HasColumnName("COMPLETION STATUS")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Costcenter")
                        .HasColumnName("COSTCENTER")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("CreditHours")
                        .HasColumnName("CREDIT HOURS")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("EMAIL")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EmployeeLearningJobTitle")
                        .HasColumnName("EMPLOYEE LEARNING JOB TITLE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EmployeeLegacyIndicator")
                        .HasColumnName("EMPLOYEE LEGACY INDICATOR")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EmployeeStatusId")
                        .HasColumnName("EMPLOYEE STATUS ID")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EmployeeSubgroup")
                        .HasColumnName("EMPLOYEE SUBGROUP")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EmployeeTypeId")
                        .HasColumnName("EMPLOYEE TYPE ID")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EntityAssignmentType")
                        .HasColumnName("ENTITY ASSIGNMENT TYPE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EntityId")
                        .HasColumnName("ENTITY ID")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EntityTitle")
                        .HasColumnName("ENTITY TITLE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EntityType")
                        .HasColumnName("ENTITY TYPE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Grade")
                        .HasColumnName("GRADE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Instructor")
                        .HasColumnName("INSTRUCTOR")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("JobLocation")
                        .HasColumnName("JOB LOCATION")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("LastUpdatedAt")
                        .HasColumnName("LAST UPDATED AT")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnName("LAST UPDATED BY")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("ScheduledOfferingId")
                        .HasColumnName("SCHEDULED OFFERING ID")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("SuperEmail")
                        .HasColumnName("SUPER EMAIL")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("SupervisorName")
                        .HasColumnName("SUPERVISOR NAME")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("TotalHours")
                        .HasColumnName("TOTAL HOURS")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserDepartment")
                        .HasColumnName("USER DEPARTMENT")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserDomain")
                        .HasColumnName("USER DOMAIN")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserFirstName")
                        .HasColumnName("USER FIRST NAME")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserId")
                        .HasColumnName("USER ID")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserJobTitle")
                        .HasColumnName("USER JOB TITLE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserJobTitleDate")
                        .HasColumnName("USER JOB TITLE DATE")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserLastName")
                        .HasColumnName("USER LAST NAME")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserMiddleInitial")
                        .HasColumnName("USER MIDDLE INITIAL")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserOrgLevel2")
                        .HasColumnName("USER ORG LEVEL 2")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserOrgLevel3")
                        .HasColumnName("USER ORG LEVEL 3")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserOrgLevel4")
                        .HasColumnName("USER ORG LEVEL 4")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserOrgLevel5")
                        .HasColumnName("USER ORG LEVEL 5")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserOrgLevel6")
                        .HasColumnName("USER ORG LEVEL 6")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserOrgLevel7")
                        .HasColumnName("USER ORG LEVEL 7")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("UserStatus")
                        .HasColumnName("USER STATUS")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("CP01PassportInactiveAllData","LegacyData");
                });

            modelBuilder.Entity("LegacyData.Models.Models.TestNewClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("TestNewClass","LegacyData");
                });

            modelBuilder.Entity("LegacyData.Models.Models.VTAInactiveAllData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("badge_scan")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("bin_crse_k")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("calc_cdate")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("cert_no")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("code")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("comp_date")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("crse_grade")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("crse_score")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("crse_site")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("crse_title")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("date_hire")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("department")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("emp_group")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("emp_id")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("emp_key")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("end_date")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("firstname")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("job_title")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("lastname")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("m_init")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("no_complet")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("no_lessons")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("position")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("rptkey")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("sess_date")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("sess_hrs")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("sess_key")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("sess_num")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("sess_stat")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("shift")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("status")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("train_hrs")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("workarea")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CP01VTAInactiveAllData","LegacyData");
                });
#pragma warning restore 612, 618
        }
    }
}
