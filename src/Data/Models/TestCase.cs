using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace tcms.Data.Models
{
	[Table("TestCases", Schema = "testcases")]
	[Index(nameof(Title))]
	public class TestCase : BaseEntity
	{
		public int TestCaseId { get; set; }

		[Required, StringLength(100)]
		public string Title { get; set; }

		[Required, StringLength(500)]
		public string Description { get; set; }

		[Required, StringLength(2000)]
		public string Text { get; set; }

		// [Range(0, 99)]
		public double EstimateHr { get; set; }

		public virtual ICollection<TestCaseStep> Steps { get; set; }

		[Required]
		public int ComponentId { get; set; }
		public Component Component { get; set; }

		[Required]
		public int StatusId { get; set; }
		public TestCaseStatus Status { get; set; }

		public int TypeId { get; set; }
		public TestCaseType Type { get; set; }

		public int PriorityId { get; set; }
		public TestCasePriority Priority { get; set; }

		public bool IsAutomated { get; set; } = false;
	}
}