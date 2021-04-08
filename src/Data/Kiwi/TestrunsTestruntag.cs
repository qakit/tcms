using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestrunsTestruntag
    {
        public int Id { get; set; }
        public int RunId { get; set; }
        public int TagId { get; set; }

        public virtual TestrunsTestrun Run { get; set; }
        public virtual ManagementTag Tag { get; set; }
    }
}
