using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Testcasetag
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int TagId { get; set; }

        public virtual Testcase Case { get; set; }
        public virtual ManagementTag Tag { get; set; }
    }
}
