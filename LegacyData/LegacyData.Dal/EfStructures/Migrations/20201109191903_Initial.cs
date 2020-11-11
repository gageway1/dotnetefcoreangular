using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LegacyData.Dal.EfStructures.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LegacyData");

            migrationBuilder.CreateTable(
                name: "CP01PassportInactiveAllData",
                schema: "LegacyData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    USERID = table.Column<string>(name: "USER ID", unicode: false, maxLength: 500, nullable: true),
                    USERFIRSTNAME = table.Column<string>(name: "USER FIRST NAME", unicode: false, maxLength: 500, nullable: true),
                    USERLASTNAME = table.Column<string>(name: "USER LAST NAME", unicode: false, maxLength: 500, nullable: true),
                    USERMIDDLEINITIAL = table.Column<string>(name: "USER MIDDLE INITIAL", unicode: false, maxLength: 500, nullable: true),
                    ENTITYID = table.Column<string>(name: "ENTITY ID", unicode: false, maxLength: 500, nullable: true),
                    ENTITYTYPE = table.Column<string>(name: "ENTITY TYPE", unicode: false, maxLength: 500, nullable: true),
                    ENTITYTITLE = table.Column<string>(name: "ENTITY TITLE", unicode: false, maxLength: 500, nullable: true),
                    COMPLETIONDATE = table.Column<string>(name: "COMPLETION DATE", unicode: false, maxLength: 500, nullable: true),
                    COMPLETIONSTATUS = table.Column<string>(name: "COMPLETION STATUS", unicode: false, maxLength: 500, nullable: true),
                    GRADE = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CREDITHOURS = table.Column<string>(name: "CREDIT HOURS", unicode: false, maxLength: 500, nullable: true),
                    TOTALHOURS = table.Column<string>(name: "TOTAL HOURS", unicode: false, maxLength: 500, nullable: true),
                    ENTITYASSIGNMENTTYPE = table.Column<string>(name: "ENTITY ASSIGNMENT TYPE", unicode: false, maxLength: 500, nullable: true),
                    SCHEDULEDOFFERINGID = table.Column<string>(name: "SCHEDULED OFFERING ID", unicode: false, maxLength: 500, nullable: true),
                    INSTRUCTOR = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    COMMENTS = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    USERDOMAIN = table.Column<string>(name: "USER DOMAIN", unicode: false, maxLength: 500, nullable: true),
                    USERSTATUS = table.Column<string>(name: "USER STATUS", unicode: false, maxLength: 500, nullable: true),
                    USERJOBTITLE = table.Column<string>(name: "USER JOB TITLE", unicode: false, maxLength: 500, nullable: true),
                    USERJOBTITLEDATE = table.Column<string>(name: "USER JOB TITLE DATE", unicode: false, maxLength: 500, nullable: true),
                    USERDEPARTMENT = table.Column<string>(name: "USER DEPARTMENT", unicode: false, maxLength: 500, nullable: true),
                    USERORGLEVEL2 = table.Column<string>(name: "USER ORG LEVEL 2", unicode: false, maxLength: 500, nullable: true),
                    USERORGLEVEL3 = table.Column<string>(name: "USER ORG LEVEL 3", unicode: false, maxLength: 500, nullable: true),
                    USERORGLEVEL4 = table.Column<string>(name: "USER ORG LEVEL 4", unicode: false, maxLength: 500, nullable: true),
                    USERORGLEVEL5 = table.Column<string>(name: "USER ORG LEVEL 5", unicode: false, maxLength: 500, nullable: true),
                    USERORGLEVEL6 = table.Column<string>(name: "USER ORG LEVEL 6", unicode: false, maxLength: 500, nullable: true),
                    USERORGLEVEL7 = table.Column<string>(name: "USER ORG LEVEL 7", unicode: false, maxLength: 500, nullable: true),
                    EMPLOYEETYPEID = table.Column<string>(name: "EMPLOYEE TYPE ID", unicode: false, maxLength: 500, nullable: true),
                    EMPLOYEESUBGROUP = table.Column<string>(name: "EMPLOYEE SUBGROUP", unicode: false, maxLength: 500, nullable: true),
                    EMPLOYEESTATUSID = table.Column<string>(name: "EMPLOYEE STATUS ID", unicode: false, maxLength: 500, nullable: true),
                    COSTCENTER = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    EMAIL = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    SUPERVISORNAME = table.Column<string>(name: "SUPERVISOR NAME", unicode: false, maxLength: 500, nullable: true),
                    SUPEREMAIL = table.Column<string>(name: "SUPER EMAIL", unicode: false, maxLength: 500, nullable: true),
                    JOBLOCATION = table.Column<string>(name: "JOB LOCATION", unicode: false, maxLength: 500, nullable: true),
                    LASTUPDATEDBY = table.Column<string>(name: "LAST UPDATED BY", unicode: false, maxLength: 500, nullable: true),
                    LASTUPDATEDAT = table.Column<string>(name: "LAST UPDATED AT", unicode: false, maxLength: 500, nullable: true),
                    EMPLOYEELEGACYINDICATOR = table.Column<string>(name: "EMPLOYEE LEGACY INDICATOR", unicode: false, maxLength: 500, nullable: true),
                    EMPLOYEELEARNINGJOBTITLE = table.Column<string>(name: "EMPLOYEE LEARNING JOB TITLE", unicode: false, maxLength: 500, nullable: true),
                    AM = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    AN = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP01PassportInactiveAllData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CP01VTAInactiveAllData",
                schema: "LegacyData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    emp_group = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    lastname = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    firstname = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    m_init = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    emp_id = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    bin_crse_k = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    comp_date = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    calc_cdate = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    sess_stat = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    sess_date = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    end_date = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    code = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    status = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    sess_num = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    crse_title = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    crse_site = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    crse_grade = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    crse_score = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    train_hrs = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    sess_hrs = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    sess_key = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    shift = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    department = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    workarea = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    job_title = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    no_lessons = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    no_complet = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    position = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    cert_no = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    badge_scan = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    rptkey = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    emp_key = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    date_hire = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP01VTAInactiveAllData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CP01PassportInactiveAllData",
                schema: "LegacyData");

            migrationBuilder.DropTable(
                name: "CP01VTAInactiveAllData",
                schema: "LegacyData");
        }
    }
}
