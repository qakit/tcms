using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("Priorities", Schema = "testcases")]
	public class TestCasePriority : BaseEntity
	{
		public int TestCasePriorityId { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
