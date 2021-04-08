using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class DjangoContentType
    {
        public DjangoContentType()
        {
            AttachmentsAttachments = new HashSet<AttachmentsAttachment>();
            AuthPermissions = new HashSet<AuthPermission>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            DjangoComments = new HashSet<DjangoComment>();
            GuardianGroupobjectpermissions = new HashSet<GuardianGroupobjectpermission>();
            GuardianUserobjectpermissions = new HashSet<GuardianUserobjectpermission>();
        }

        public int Id { get; set; }
        public string AppLabel { get; set; }
        public string Model { get; set; }

        public virtual ICollection<AttachmentsAttachment> AttachmentsAttachments { get; set; }
        public virtual ICollection<AuthPermission> AuthPermissions { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<DjangoComment> DjangoComments { get; set; }
        public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }
        public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }
    }
}
