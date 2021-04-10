using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestRuns
{
    public partial class Testruntag
    {
        public int Id { get; set; }
        public int RunId { get; set; }
        public int TagId { get; set; }

        public virtual Testrun Run { get; set; }
        public virtual ManagementTag Tag { get; set; }
    }
}
