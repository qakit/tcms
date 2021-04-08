using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesTestcasetag
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int TagId { get; set; }

        public virtual TestcasesTestcase Case { get; set; }
        public virtual ManagementTag Tag { get; set; }
    }
}
