using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementClassification
    {
        public ManagementClassification()
        {
            ManagementProducts = new HashSet<ManagementProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ManagementProduct> ManagementProducts { get; set; }
    }
}
