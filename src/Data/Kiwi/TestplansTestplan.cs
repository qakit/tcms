using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestplansTestplan
    {
        public TestplansTestplan()
        {
            InverseParent = new HashSet<TestplansTestplan>();
            Testcaseplans = new HashSet<TestCases.Testcaseplan>();
            Testplantags = new HashSet<TestplansTestplantag>();
            Testruns = new HashSet<TestRuns.Testrun>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public string ExtraLink { get; set; }
        public int AuthorId { get; set; }
        public int? ParentId { get; set; }
        public int ProductId { get; set; }
        public int ProductVersionId { get; set; }
        public int TypeId { get; set; }

        public virtual AuthUser Author { get; set; }
        public virtual TestplansTestplan Parent { get; set; }
        public virtual ManagementProduct Product { get; set; }
        public virtual ManagementVersion ProductVersion { get; set; }
        public virtual TestplansPlantype Type { get; set; }
        public virtual TestplansTestplanemailsetting Testplanemailsetting { get; set; }
        public virtual ICollection<TestplansTestplan> InverseParent { get; set; }
        public virtual ICollection<TestCases.Testcaseplan> Testcaseplans { get; set; }
        public virtual ICollection<TestplansTestplantag> Testplantags { get; set; }
        public virtual ICollection<TestRuns.Testrun> Testruns { get; set; }
    }
}
