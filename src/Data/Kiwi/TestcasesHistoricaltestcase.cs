using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestcasesHistoricaltestcase
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Script { get; set; }
        public string Arguments { get; set; }
        public string ExtraLink { get; set; }
        public string Summary { get; set; }
        public string Requirement { get; set; }
        public string Notes { get; set; }
        public int HistoryId { get; set; }
        public string HistoryChangeReason { get; set; }
        public DateTime HistoryDate { get; set; }
        public string HistoryType { get; set; }
        public int? AuthorId { get; set; }
        public int? CaseStatusId { get; set; }
        public int? CategoryId { get; set; }
        public int? DefaultTesterId { get; set; }
        public int? HistoryUserId { get; set; }
        public int? PriorityId { get; set; }
        public int? ReviewerId { get; set; }
        public string Text { get; set; }
        public bool IsAutomated { get; set; }

        public virtual AuthUser HistoryUser { get; set; }
    }
}
