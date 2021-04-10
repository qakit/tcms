using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Testcasecomponent
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int ComponentId { get; set; }

        public virtual Testcase Case { get; set; }
        public virtual ManagementComponent Component { get; set; }
    }
}
