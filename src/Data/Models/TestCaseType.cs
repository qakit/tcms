using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Index(nameof(Name), IsUnique = true)]
	[Table("Types", Schema = "testcases")]
	public class TestCaseType : BaseEntity
	{
		public int TestCaseTypeId { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
