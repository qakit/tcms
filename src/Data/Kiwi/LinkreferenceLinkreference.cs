using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class LinkreferenceLinkreference
    {
        public int Id { get; set; }
        public int ExecutionId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDefect { get; set; }

        public virtual TestRuns.Testexecution Execution { get; set; }
    }
}
