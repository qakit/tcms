using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementPriority
    {
        public ManagementPriority()
        {
            Testcases = new HashSet<TestCases.Testcase>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TestCases.Testcase> Testcases { get; set; }
    }
}
