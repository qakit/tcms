using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	/// <summary>
	///By default we have at least one component (e.g. 'Default')
	/// </summary>
	public class Component
	{
		public int ComponentId { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(500)]
		public string Description { get; set; }

		public Product Product { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}