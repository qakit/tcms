using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class TestCaseStep
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
