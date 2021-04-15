using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	/// <summary>
	/// By Default should at least 3 statuses: Proposed, Approved, RequireUpdate e.g.
	/// </summary>
	public class TestCaseStatus
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
