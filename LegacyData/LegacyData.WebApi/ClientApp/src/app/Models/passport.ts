import { Base } from './base';

export interface Passport extends Base {
    userId: string;
    userFirstName: string;
    userLastName: string;
    userMiddleInitial: string;
    entityId: string;
    entityType: string;
    entityTitle: string;
    completionDate: string;
    completionStatus: string;
    grade: string;
    creditHours: string;
    TotalHours: string;
    entityAssignmentType: string;
    ScheduledOfferingId: string;
    Instructor: string;
    comments: string;
    userDomain: string;
    userStatus: string;
    userJobTitle: string;
    userJobTitleDate: string;
    userDepartment: string;
    userOrgLevel2: string;
    userOrgLevel3: string;
    userOrgLevel4: string;
    userOrgLevel5: string;
    userOrgLevel6: string;
    userOrgLevel7: string;
    employeeTypeId: string;
    employeeSubgroup: string;
    employeeStatusId: string;
    costcenter: string;
    email: string;
    supervisorName: string;
    superemail: string;
    jobLocation: string;
    lastupdatedBy: string;
    lastupdatedAt: string;
    employeeLegacyIndicator: string;
    employeeLearningJobTitle: string;
    am: string;
    an: string;

}
