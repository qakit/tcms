using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementBuild
    {
        public ManagementBuild()
        {
            BugsBugs = new HashSet<BugsBug>();
            Testexecutions = new HashSet<TestRuns.Testexecution>();
            Testruns = new HashSet<TestRuns.Testrun>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int VersionId { get; set; }

        public virtual ManagementVersion Version { get; set; }
        public virtual ICollection<BugsBug> BugsBugs { get; set; }
        public virtual ICollection<TestRuns.Testexecution> Testexecutions { get; set; }
        public virtual ICollection<TestRuns.Testrun> Testruns { get; set; }
    }
}
