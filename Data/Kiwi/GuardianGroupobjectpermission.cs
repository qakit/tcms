using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class GuardianGroupobjectpermission
    {
        public int Id { get; set; }
        public string ObjectPk { get; set; }
        public int ContentTypeId { get; set; }
        public int GroupId { get; set; }
        public int PermissionId { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual AuthGroup Group { get; set; }
        public virtual AuthPermission Permission { get; set; }
    }
}
