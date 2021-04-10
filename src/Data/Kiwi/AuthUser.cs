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
            Historicaltestcases = new HashSet<TestCases.Historicaltestcase>();
            TestcaseAuthors = new HashSet<TestCases.Testcase>();
            TestcaseDefaultTesters = new HashSet<TestCases.Testcase>();
            TestcaseReviewers = new HashSet<TestCases.Testcase>();
            TestplansHistoricaltestplans = new HashSet<TestplansHistoricaltestplan>();
            Testplans = new HashSet<TestplansTestplan>();
            Historicaltestexecutions = new HashSet<TestRuns.Historicaltestexecution>();
            Historicaltestruns = new HashSet<TestRuns.Historicaltestrun>();
            TestexecutionAssignees = new HashSet<TestRuns.Testexecution>();
            TestexecutionTestedBies = new HashSet<TestRuns.Testexecution>();
            TestrunDefaultTesters = new HashSet<TestRuns.Testrun>();
            TestrunManagers = new HashSet<TestRuns.Testrun>();
            Testrunccs = new HashSet<TestRuns.Testruncc>();
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
        public virtual ICollection<TestCases.Historicaltestcase> Historicaltestcases { get; set; }
        public virtual ICollection<TestCases.Testcase> TestcaseAuthors { get; set; }
        public virtual ICollection<TestCases.Testcase> TestcaseDefaultTesters { get; set; }
        public virtual ICollection<TestCases.Testcase> TestcaseReviewers { get; set; }
        public virtual ICollection<TestplansHistoricaltestplan> TestplansHistoricaltestplans { get; set; }
        public virtual ICollection<TestplansTestplan> Testplans { get; set; }
        public virtual ICollection<TestRuns.Historicaltestexecution> Historicaltestexecutions { get; set; }
        public virtual ICollection<TestRuns.Historicaltestrun> Historicaltestruns { get; set; }
        public virtual ICollection<TestRuns.Testexecution> TestexecutionAssignees { get; set; }
        public virtual ICollection<TestRuns.Testexecution> TestexecutionTestedBies { get; set; }
        public virtual ICollection<TestRuns.Testrun> TestrunDefaultTesters { get; set; }
        public virtual ICollection<TestRuns.Testrun> TestrunManagers { get; set; }
        public virtual ICollection<TestRuns.Testruncc> Testrunccs { get; set; }
    }
}
