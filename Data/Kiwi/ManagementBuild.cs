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
            TestrunsTestexecutions = new HashSet<TestrunsTestexecution>();
            TestrunsTestruns = new HashSet<TestrunsTestrun>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int VersionId { get; set; }

        public virtual ManagementVersion Version { get; set; }
        public virtual ICollection<BugsBug> BugsBugs { get; set; }
        public virtual ICollection<TestrunsTestexecution> TestrunsTestexecutions { get; set; }
        public virtual ICollection<TestrunsTestrun> TestrunsTestruns { get; set; }
    }
}
