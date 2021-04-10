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
            Testcasetags = new HashSet<TestCases.Testcasetag>();
            Testplantags = new HashSet<TestplansTestplantag>();
            Testruntags = new HashSet<TestRuns.Testruntag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BugsBugTag> BugsBugTags { get; set; }
        public virtual ICollection<TestCases.Testcasetag> Testcasetags { get; set; }
        public virtual ICollection<TestplansTestplantag> Testplantags { get; set; }
        public virtual ICollection<TestRuns.Testruntag> Testruntags { get; set; }
    }
}
