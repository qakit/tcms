using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class AttachmentsAttachment
    {
        public int Id { get; set; }
        public string ObjectId { get; set; }
        public string AttachmentFile { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int ContentTypeId { get; set; }
        public int CreatorId { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual AuthUser Creator { get; set; }
    }
}
