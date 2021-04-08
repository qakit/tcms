using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementTag
    {
        public ManagementTag()
        {
            BugsBugTags = new HashSet<BugsBugTag>();
            TestcasesTestcasetags = new HashSet<TestcasesTestcasetag>();
            TestplansTestplantags = new HashSet<TestplansTestplantag>();
            TestrunsTestruntags = new HashSet<TestrunsTestruntag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BugsBugTag> BugsBugTags { get; set; }
        public virtual ICollection<TestcasesTestcasetag> TestcasesTestcasetags { get; set; }
        public virtual ICollection<TestplansTestplantag> TestplansTestplantags { get; set; }
        public virtual ICollection<TestrunsTestruntag> TestrunsTestruntags { get; set; }
    }
}
