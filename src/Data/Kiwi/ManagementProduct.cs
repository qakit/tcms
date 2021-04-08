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
            TestcasesCategories = new HashSet<TestcasesCategory>();
            TestplansTestplans = new HashSet<TestplansTestplan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClassificationId { get; set; }

        public virtual ManagementClassification Classification { get; set; }
        public virtual ICollection<BugsBug> BugsBugs { get; set; }
        public virtual ICollection<ManagementComponent> ManagementComponents { get; set; }
        public virtual ICollection<ManagementVersion> ManagementVersions { get; set; }
        public virtual ICollection<TestcasesCategory> TestcasesCategories { get; set; }
        public virtual ICollection<TestplansTestplan> TestplansTestplans { get; set; }
    }
}
