using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class DjangoSite
    {
        public DjangoSite()
        {
            DjangoComments = new HashSet<DjangoComment>();
        }

        public int Id { get; set; }
        public string Domain { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DjangoComment> DjangoComments { get; set; }
    }
}
