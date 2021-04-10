using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestRuns
{
    public partial class Testruncc
    {
        public int Id { get; set; }
        public int RunId { get; set; }
        public int UserId { get; set; }

        public virtual Testrun Run { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
