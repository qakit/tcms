using System;
using System.Collections.Generic;
using System.Net;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class DjangoComment
    {
        public DjangoComment()
        {
            DjangoCommentFlags = new HashSet<DjangoCommentFlag>();
        }

        public int Id { get; set; }
        public string ObjectPk { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserUrl { get; set; }
        public string Comment { get; set; }
        public DateTime SubmitDate { get; set; }
        public IPAddress IpAddress { get; set; }
        public bool IsPublic { get; set; }
        public bool IsRemoved { get; set; }
        public int ContentTypeId { get; set; }
        public int SiteId { get; set; }
        public int? UserId { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual DjangoSite Site { get; set; }
        public virtual AuthUser User { get; set; }
        public virtual ICollection<DjangoCommentFlag> DjangoCommentFlags { get; set; }
    }
}
