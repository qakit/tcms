using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestRuns
{
    public partial class Testexecution
    {
        public Testexecution()
        {
            BugsBugExecutions = new HashSet<BugsBugExecution>();
            LinkreferenceLinkreferences = new HashSet<LinkreferenceLinkreference>();
        }

        public int Id { get; set; }
        public int CaseTextVersion { get; set; }
        public DateTime? StopDate { get; set; }
        public int? Sortkey { get; set; }
        public int? AssigneeId { get; set; }
        public int BuildId { get; set; }
        public int CaseId { get; set; }
        public int StatusId { get; set; }
        public int RunId { get; set; }
        public int? TestedById { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual AuthUser Assignee { get; set; }
        public virtual ManagementBuild Build { get; set; }
        public virtual TestCases.Testcase Case { get; set; }
        public virtual Testrun Run { get; set; }
        public virtual Testexecutionstatus Status { get; set; }
        public virtual AuthUser TestedBy { get; set; }
        public virtual ICollection<BugsBugExecution> BugsBugExecutions { get; set; }
        public virtual ICollection<LinkreferenceLinkreference> LinkreferenceLinkreferences { get; set; }
    }
}
