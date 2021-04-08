using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class AuthGroup
    {
        public AuthGroup()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermission>();
            AuthUserGroups = new HashSet<AuthUserGroup>();
            GuardianGroupobjectpermissions = new HashSet<GuardianGroupobjectpermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }
    }
}
