using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("Statuses", Schema = "testcases")]
	public class TestCaseStatus : BaseEntity
	{
		public int TestCaseStatusId { get; set; }

		[Required, StringLength(25)]
		public string Name { get; set; }

		public bool IsApproved { get; set; } = false;

		[StringLength(250)]
		public string Description { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
