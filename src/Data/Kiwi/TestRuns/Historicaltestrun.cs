using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi.TestRuns
{
    public partial class Historicaltestrun
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public string Summary { get; set; }
        public string Notes { get; set; }
        public int HistoryId { get; set; }
        public string HistoryChangeReason { get; set; }
        public DateTime HistoryDate { get; set; }
        public string HistoryType { get; set; }
        public int? BuildId { get; set; }
        public int? DefaultTesterId { get; set; }
        public int? HistoryUserId { get; set; }
        public int? ManagerId { get; set; }
        public int? PlanId { get; set; }
        public int? ProductVersionId { get; set; }
        public DateTime? PlannedStart { get; set; }
        public DateTime? PlannedStop { get; set; }

        public virtual AuthUser HistoryUser { get; set; }
    }
}
