using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestCases
{
    public partial class Testcasestatus
    {
        public Testcasestatus()
        {
            Testcases = new HashSet<Testcase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsConfirmed { get; set; }

        public virtual ICollection<Testcase> Testcases { get; set; }
    }
}
