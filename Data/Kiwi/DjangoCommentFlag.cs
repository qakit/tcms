using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class DjangoCommentFlag
    {
        public int Id { get; set; }
        public string Flag { get; set; }
        public DateTime FlagDate { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }

        public virtual DjangoComment Comment { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
