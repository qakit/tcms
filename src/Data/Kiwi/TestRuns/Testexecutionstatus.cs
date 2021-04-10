using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestRuns
{
    public partial class Testexecutionstatus
    {
        public Testexecutionstatus()
        {
            Testexecutions = new HashSet<Testexecution>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }

        public virtual ICollection<Testexecution> Testexecutions { get; set; }
    }
}
