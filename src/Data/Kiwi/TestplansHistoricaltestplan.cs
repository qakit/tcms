using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestplansHistoricaltestplan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public string ExtraLink { get; set; }
        public int HistoryId { get; set; }
        public string HistoryChangeReason { get; set; }
        public DateTime HistoryDate { get; set; }
        public string HistoryType { get; set; }
        public int? AuthorId { get; set; }
        public int? HistoryUserId { get; set; }
        public int? ParentId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductVersionId { get; set; }
        public int? TypeId { get; set; }
        public string Text { get; set; }

        public virtual AuthUser HistoryUser { get; set; }
    }
}
