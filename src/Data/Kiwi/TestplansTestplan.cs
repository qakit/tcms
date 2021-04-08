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
            TestcasesTestcaseplans = new HashSet<TestcasesTestcaseplan>();
            TestplansTestplantags = new HashSet<TestplansTestplantag>();
            TestrunsTestruns = new HashSet<TestrunsTestrun>();
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
        public virtual TestplansTestplanemailsetting TestplansTestplanemailsetting { get; set; }
        public virtual ICollection<TestplansTestplan> InverseParent { get; set; }
        public virtual ICollection<TestcasesTestcaseplan> TestcasesTestcaseplans { get; set; }
        public virtual ICollection<TestplansTestplantag> TestplansTestplantags { get; set; }
        public virtual ICollection<TestrunsTestrun> TestrunsTestruns { get; set; }
    }
}
