using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Category
    {
        public Category()
        {
            Testcases = new HashSet<TestCases.Testcase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

        public virtual ManagementProduct Product { get; set; }
        public virtual ICollection<Testcase> Testcases { get; set; }
    }
}
