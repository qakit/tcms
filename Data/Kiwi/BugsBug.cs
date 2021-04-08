using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class BugsBug
    {
        public BugsBug()
        {
            BugsBugExecutions = new HashSet<BugsBugExecution>();
            BugsBugTags = new HashSet<BugsBugTag>();
        }

        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public int? AssigneeId { get; set; }
        public int BuildId { get; set; }
        public int ProductId { get; set; }
        public int ReporterId { get; set; }
        public int VersionId { get; set; }

        public virtual AuthUser Assignee { get; set; }
        public virtual ManagementBuild Build { get; set; }
        public virtual ManagementProduct Product { get; set; }
        public virtual AuthUser Reporter { get; set; }
        public virtual ManagementVersion Version { get; set; }
        public virtual ICollection<BugsBugExecution> BugsBugExecutions { get; set; }
        public virtual ICollection<BugsBugTag> BugsBugTags { get; set; }
    }
}
