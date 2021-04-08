using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesCategory
    {
        public TestcasesCategory()
        {
            TestcasesTestcases = new HashSet<TestcasesTestcase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

        public virtual ManagementProduct Product { get; set; }
        public virtual ICollection<TestcasesTestcase> TestcasesTestcases { get; set; }
    }
}
