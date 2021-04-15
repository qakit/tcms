using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("Steps", Schema = "testcases")]
	public class TestCaseStep : BaseEntity
	{
		public int TestCaseStepId { get; set; }

		[Required]
		public string Text { get; set; }

		public bool IsPrecondition { get; set; } = false;

		[Required]
		public int Ordinal { get; set; }

		[ForeignKey("TestCase")]
		public int TestCaseId { get; set; }
		public virtual TestCase TestCase { get; set; }

		public virtual ICollection<Attachment> Attachments { get; set; }
	}
}
