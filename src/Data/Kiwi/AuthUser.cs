using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class AuthUser
    {
        public AuthUser()
        {
            AttachmentsAttachments = new HashSet<AttachmentsAttachment>();
            AuthUserGroups = new HashSet<AuthUserGroup>();
            AuthUserUserPermissions = new HashSet<AuthUserUserPermission>();
            BugsBugAssignees = new HashSet<BugsBug>();
            BugsBugReporters = new HashSet<BugsBug>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            DjangoCommentFlags = new HashSet<DjangoCommentFlag>();
            DjangoComments = new HashSet<DjangoComment>();
            GuardianUserobjectpermissions = new HashSet<GuardianUserobjectpermission>();
            KiwiAuthUseractivationkeys = new HashSet<KiwiAuthUseractivationkey>();
            ManagementComponentInitialOwners = new HashSet<ManagementComponent>();
            ManagementComponentInitialQaContacts = new HashSet<ManagementComponent>();
            TestcasesHistoricaltestcases = new HashSet<TestcasesHistoricaltestcase>();
            TestcasesTestcaseAuthors = new HashSet<TestcasesTestcase>();
            TestcasesTestcaseDefaultTesters = new HashSet<TestcasesTestcase>();
            TestcasesTestcaseReviewers = new HashSet<TestcasesTestcase>();
            TestplansHistoricaltestplans = new HashSet<TestplansHistoricaltestplan>();
            TestplansTestplans = new HashSet<TestplansTestplan>();
            TestrunsHistoricaltestexecutions = new HashSet<TestrunsHistoricaltestexecution>();
            TestrunsHistoricaltestruns = new HashSet<TestrunsHistoricaltestrun>();
            TestrunsTestexecutionAssignees = new HashSet<TestrunsTestexecution>();
            TestrunsTestexecutionTestedBies = new HashSet<TestrunsTestexecution>();
            TestrunsTestrunDefaultTesters = new HashSet<TestrunsTestrun>();
            TestrunsTestrunManagers = new HashSet<TestrunsTestrun>();
            TestrunsTestrunccs = new HashSet<TestrunsTestruncc>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsSuperuser { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateJoined { get; set; }

        public virtual ICollection<AttachmentsAttachment> AttachmentsAttachments { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual ICollection<BugsBug> BugsBugAssignees { get; set; }
        public virtual ICollection<BugsBug> BugsBugReporters { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<DjangoCommentFlag> DjangoCommentFlags { get; set; }
        public virtual ICollection<DjangoComment> DjangoComments { get; set; }
        public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }
        public virtual ICollection<KiwiAuthUseractivationkey> KiwiAuthUseractivationkeys { get; set; }
        public virtual ICollection<ManagementComponent> ManagementComponentInitialOwners { get; set; }
        public virtual ICollection<ManagementComponent> ManagementComponentInitialQaContacts { get; set; }
        public virtual ICollection<TestcasesHistoricaltestcase> TestcasesHistoricaltestcases { get; set; }
        public virtual ICollection<TestcasesTestcase> TestcasesTestcaseAuthors { get; set; }
        public virtual ICollection<TestcasesTestcase> TestcasesTestcaseDefaultTesters { get; set; }
        public virtual ICollection<TestcasesTestcase> TestcasesTestcaseReviewers { get; set; }
        public virtual ICollection<TestplansHistoricaltestplan> TestplansHistoricaltestplans { get; set; }
        public virtual ICollection<TestplansTestplan> TestplansTestplans { get; set; }
        public virtual ICollection<TestrunsHistoricaltestexecution> TestrunsHistoricaltestexecutions { get; set; }
        public virtual ICollection<TestrunsHistoricaltestrun> TestrunsHistoricaltestruns { get; set; }
        public virtual ICollection<TestrunsTestexecution> TestrunsTestexecutionAssignees { get; set; }
        public virtual ICollection<TestrunsTestexecution> TestrunsTestexecutionTestedBies { get; set; }
        public virtual ICollection<TestrunsTestrun> TestrunsTestrunDefaultTesters { get; set; }
        public virtual ICollection<TestrunsTestrun> TestrunsTestrunManagers { get; set; }
        public virtual ICollection<TestrunsTestruncc> TestrunsTestrunccs { get; set; }
    }
}
