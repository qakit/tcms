using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class BugsBugExecution
    {
        public int Id { get; set; }
        public int BugId { get; set; }
        public int TestexecutionId { get; set; }

        public virtual BugsBug Bug { get; set; }
        public virtual TestrunsTestexecution Testexecution { get; set; }
    }
}
