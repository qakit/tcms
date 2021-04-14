using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class Milestone
	{
		[Key]
		public int MilestoneID { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[StringLength(250)]
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		[ForeignKey("ProjectId")]
		public virtual Project Project { get; set; }
	}
}
