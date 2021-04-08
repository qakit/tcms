using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class GuardianUserobjectpermission
    {
        public int Id { get; set; }
        public string ObjectPk { get; set; }
        public int ContentTypeId { get; set; }
        public int PermissionId { get; set; }
        public int UserId { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual AuthPermission Permission { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
