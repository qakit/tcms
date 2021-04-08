using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class DjangoMigration
    {
        public int Id { get; set; }
        public string App { get; set; }
        public string Name { get; set; }
        public DateTime Applied { get; set; }
    }
}
