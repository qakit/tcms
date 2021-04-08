using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestplansTestplanemailsetting
    {
        public int Id { get; set; }
        public bool AutoToPlanAuthor { get; set; }
        public bool AutoToCaseOwner { get; set; }
        public bool AutoToCaseDefaultTester { get; set; }
        public bool NotifyOnPlanUpdate { get; set; }
        public bool NotifyOnCaseUpdate { get; set; }
        public int PlanId { get; set; }

        public virtual TestplansTestplan Plan { get; set; }
    }
}
