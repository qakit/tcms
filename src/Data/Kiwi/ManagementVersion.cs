using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementVersion
    {
        public ManagementVersion()
        {
            BugsBugs = new HashSet<BugsBug>();
            ManagementBuilds = new HashSet<ManagementBuild>();
            Testplans = new HashSet<TestplansTestplan>();
            Testruns = new HashSet<TestRuns.Testrun>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }

        public virtual ManagementProduct Product { get; set; }
        public virtual ICollection<BugsBug> BugsBugs { get; set; }
        public virtual ICollection<ManagementBuild> ManagementBuilds { get; set; }
        public virtual ICollection<TestplansTestplan> Testplans { get; set; }
        public virtual ICollection<TestRuns.Testrun> Testruns { get; set; }
    }
}
