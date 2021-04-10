using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Testcase
    {
        public Testcase()
        {
            Testcasecomponents = new HashSet<Testcasecomponent>();
            Testcaseplans = new HashSet<Testcaseplan>();
            Testcasetags = new HashSet<Testcasetag>();
            Testexecutions = new HashSet<TestRuns.Testexecution>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Script { get; set; }
        public string Arguments { get; set; }
        public string ExtraLink { get; set; }
        public string Summary { get; set; }
        public string Requirement { get; set; }
        public string Notes { get; set; }
        public int AuthorId { get; set; }
        public int CaseStatusId { get; set; }
        public int CategoryId { get; set; }
        public int? DefaultTesterId { get; set; }
        public int PriorityId { get; set; }
        public int? ReviewerId { get; set; }
        public string Text { get; set; }
        public bool IsAutomated { get; set; }

        public virtual AuthUser Author { get; set; }
        public virtual Testcasestatus CaseStatus { get; set; }
        public virtual Category Category { get; set; }
        public virtual AuthUser DefaultTester { get; set; }
        public virtual ManagementPriority Priority { get; set; }
        public virtual AuthUser Reviewer { get; set; }
        public virtual Testcaseemailsetting Testcaseemailsetting { get; set; }
        public virtual ICollection<Testcasecomponent> Testcasecomponents { get; set; }
        public virtual ICollection<Testcaseplan> Testcaseplans { get; set; }
        public virtual ICollection<Testcasetag> Testcasetags { get; set; }
        public virtual ICollection<TestRuns.Testexecution> Testexecutions { get; set; }
    }
}
