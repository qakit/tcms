using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Testcaseplan
    {
        public int Id { get; set; }
        public int? Sortkey { get; set; }
        public int CaseId { get; set; }
        public int PlanId { get; set; }

        public virtual Testcase Case { get; set; }
        public virtual TestplansTestplan Plan { get; set; }
    }
}
