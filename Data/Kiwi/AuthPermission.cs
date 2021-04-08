using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class AuthPermission
    {
        public AuthPermission()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermission>();
            AuthUserUserPermissions = new HashSet<AuthUserUserPermission>();
            GuardianGroupobjectpermissions = new HashSet<GuardianGroupobjectpermission>();
            GuardianUserobjectpermissions = new HashSet<GuardianUserobjectpermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ContentTypeId { get; set; }
        public string Codename { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }
        public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }
    }
}
