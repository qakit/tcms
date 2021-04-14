using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	public class Project
	{
		[Key]
		public int ProjectId { get; set; }
		
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[StringLength(500)]
		public string Description { get; set; }

		public virtual ICollection<Milestone> Milestones { get; set; }
		public virtual ICollection<Component> Components { get; set; }
	}
}
