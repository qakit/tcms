using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	/// <summary>
	/// By default we should have several types: Functional, Usability, Performance, Regression.. 
	/// Others can be added manually e.g.
	/// </summary>
	public class TestCaseType
	{
		[Key]
		public int TestCaseTypeId { get; set; }
		[Required]
		public string Name { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
