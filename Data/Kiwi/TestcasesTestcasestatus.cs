using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesTestcasestatus
    {
        public TestcasesTestcasestatus()
        {
            TestcasesTestcases = new HashSet<TestcasesTestcase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsConfirmed { get; set; }

        public virtual ICollection<TestcasesTestcase> TestcasesTestcases { get; set; }
    }
}
