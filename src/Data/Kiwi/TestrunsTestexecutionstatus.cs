using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestrunsTestexecutionstatus
    {
        public TestrunsTestexecutionstatus()
        {
            TestrunsTestexecutions = new HashSet<TestrunsTestexecution>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }

        public virtual ICollection<TestrunsTestexecution> TestrunsTestexecutions { get; set; }
    }
}
