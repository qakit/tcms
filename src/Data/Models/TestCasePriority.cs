using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	/// <summary>
	/// By default: hight, low, medium? other can be added/edited manually
	/// </summary>
	public class TestCasePriority
	{
		public int TestCasePriorityId { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
