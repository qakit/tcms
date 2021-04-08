using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class KiwiAuthUseractivationkey
    {
        public int Id { get; set; }
        public string ActivationKey { get; set; }
        public DateTime? KeyExpires { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; }
    }
}
