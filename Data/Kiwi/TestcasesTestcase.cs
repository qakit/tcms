using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesTestcase
    {
        public TestcasesTestcase()
        {
            TestcasesTestcasecomponents = new HashSet<TestcasesTestcasecomponent>();
            TestcasesTestcaseplans = new HashSet<TestcasesTestcaseplan>();
            TestcasesTestcasetags = new HashSet<TestcasesTestcasetag>();
            TestrunsTestexecutions = new HashSet<TestrunsTestexecution>();
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
        public virtual TestcasesTestcasestatus CaseStatus { get; set; }
        public virtual TestcasesCategory Category { get; set; }
        public virtual AuthUser DefaultTester { get; set; }
        public virtual ManagementPriority Priority { get; set; }
        public virtual AuthUser Reviewer { get; set; }
        public virtual TestcasesTestcaseemailsetting TestcasesTestcaseemailsetting { get; set; }
        public virtual ICollection<TestcasesTestcasecomponent> TestcasesTestcasecomponents { get; set; }
        public virtual ICollection<TestcasesTestcaseplan> TestcasesTestcaseplans { get; set; }
        public virtual ICollection<TestcasesTestcasetag> TestcasesTestcasetags { get; set; }
        public virtual ICollection<TestrunsTestexecution> TestrunsTestexecutions { get; set; }
    }
}
