using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesTestcasecomponent
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int ComponentId { get; set; }

        public virtual TestcasesTestcase Case { get; set; }
        public virtual ManagementComponent Component { get; set; }
    }
}
