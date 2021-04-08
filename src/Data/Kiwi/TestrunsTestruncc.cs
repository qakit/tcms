using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestrunsTestruncc
    {
        public int Id { get; set; }
        public int RunId { get; set; }
        public int UserId { get; set; }

        public virtual TestrunsTestrun Run { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
