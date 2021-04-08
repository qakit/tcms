using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class BugsBugTag
    {
        public int Id { get; set; }
        public int BugId { get; set; }
        public int TagId { get; set; }

        public virtual BugsBug Bug { get; set; }
        public virtual ManagementTag Tag { get; set; }
    }
}
