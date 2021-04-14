using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	/// <summary>
	/// By Default should at least 3 statuses: Proposed, Approved, RequireUpdate e.g.
	/// </summary>
	public class TestCaseStatus
	{
		[Key]
		public int TestCaseStatusId { get; set; }
		[Required]
		public string Name { get; set; }
		[StringLength(250)]
		public string Description { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
