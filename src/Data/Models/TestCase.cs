using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("TestCases", Schema = "testcases")]
	public class TestCase : BaseEntity
	{
		public int TestCaseId { get; set; }

		[Required, StringLength(500)]
		public string Title { get; set; }

		public string Description { get; set; }

		public double EstimateHr { get; set; }

		public virtual ICollection<TestCaseStep> Steps { get; set; }

		[Required]
		public Component Component { get; set; }

		[Required]
		public TestCaseStatus Status { get; set; }

		public TestCaseType Type { get; set; }

		public TestCasePriority Priority { get; set; }

		public bool IsAutomated { get; set; } = false;
	}
}