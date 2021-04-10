using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Testcaseemailsetting
    {
        public int Id { get; set; }
        public bool NotifyOnCaseUpdate { get; set; }
        public bool NotifyOnCaseDelete { get; set; }
        public bool AutoToCaseAuthor { get; set; }
        public bool AutoToCaseTester { get; set; }
        public bool AutoToRunManager { get; set; }
        public bool AutoToRunTester { get; set; }
        public bool AutoToExecutionAssignee { get; set; }
        public int CaseId { get; set; }
        public string CcList { get; set; }

        public virtual Testcase Case { get; set; }
    }
}
