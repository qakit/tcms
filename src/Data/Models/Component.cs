using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	/// <summary>
	///By default we have at least one component (e.g. 'Default')
	/// </summary>
	public class Component
	{
		[Key]
		public int ComponentId { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[StringLength(500)]
		public string Description { get; set; }
		
		//hierarhically build tree of components?
		public int? ParentComponentId { get; set; }
		public Component ParentComponent { get; set; }
		public Project Project { get; set; }
		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}
