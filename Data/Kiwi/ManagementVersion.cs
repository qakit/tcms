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
            TestplansTestplans = new HashSet<TestplansTestplan>();
            TestrunsTestruns = new HashSet<TestrunsTestrun>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }

        public virtual ManagementProduct Product { get; set; }
        public virtual ICollection<BugsBug> BugsBugs { get; set; }
        public virtual ICollection<ManagementBuild> ManagementBuilds { get; set; }
        public virtual ICollection<TestplansTestplan> TestplansTestplans { get; set; }
        public virtual ICollection<TestrunsTestrun> TestrunsTestruns { get; set; }
    }
}
