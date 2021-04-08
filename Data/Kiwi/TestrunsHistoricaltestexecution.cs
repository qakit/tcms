using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestrunsHistoricaltestexecution
    {
        public int Id { get; set; }
        public int CaseTextVersion { get; set; }
        public DateTime? StopDate { get; set; }
        public int? Sortkey { get; set; }
        public int HistoryId { get; set; }
        public string HistoryChangeReason { get; set; }
        public DateTime HistoryDate { get; set; }
        public string HistoryType { get; set; }
        public int? AssigneeId { get; set; }
        public int? BuildId { get; set; }
        public int? CaseId { get; set; }
        public int? StatusId { get; set; }
        public int? HistoryUserId { get; set; }
        public int? RunId { get; set; }
        public int? TestedById { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual AuthUser HistoryUser { get; set; }
    }
}
