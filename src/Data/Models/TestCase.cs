using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class TestCase
	{
		public int TestCaseId { get; set; }

		[Required, StringLength(500)]
		public string Title { get; set; }

		public string Description { get; set; }

		public double EstimateHr { get; set; }

		public List<string> References { get; set; }

		public virtual ICollection<TestCaseStep> Steps { get; set; }

		//one to one. Can one test case be part of many components?
		public Component Component { get; set; }

		public TestCaseStatus Status { get; set; }

		public TestCaseType Type { get; set; }

		public TestCasePriority Priority { get; set; }

		[ForeignKey("CreatedBy")]
		public int CreatedById { get; set; }
		public virtual User CreatedBy { get; set; }

		[ForeignKey("EditedBy")]
		public int EditedById { get; set; }
		public virtual User EditedBy { get; set; }


		//Do we need reference to project? or test case can be reused anywhere
		//e.g. parameters's behavior must be same across products
	}
}
