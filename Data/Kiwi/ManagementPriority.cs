using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementPriority
    {
        public ManagementPriority()
        {
            TestcasesTestcases = new HashSet<TestcasesTestcase>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TestcasesTestcase> TestcasesTestcases { get; set; }
    }
}
