using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestplansTestplantag
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int TagId { get; set; }

        public virtual TestplansTestplan Plan { get; set; }
        public virtual ManagementTag Tag { get; set; }
    }
}
