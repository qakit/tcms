using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class ManagementProduct
    {
        public ManagementProduct()
        {
            BugsBugs = new HashSet<BugsBug>();
            ManagementComponents = new HashSet<ManagementComponent>();
            ManagementVersions = new HashSet<ManagementVersion>();
            Categories = new HashSet<TestCases.Category>();
            Testplans = new HashSet<TestplansTestplan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClassificationId { get; set; }

        public virtual ManagementClassification Classification { get; set; }
        public virtual ICollection<BugsBug> BugsBugs { get; set; }
        public virtual ICollection<ManagementComponent> ManagementComponents { get; set; }
        public virtual ICollection<ManagementVersion> ManagementVersions { get; set; }
        public virtual ICollection<TestCases.Category> Categories { get; set; }
        public virtual ICollection<TestplansTestplan> Testplans { get; set; }
    }
}
