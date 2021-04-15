using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class Attachment
	{
		public int AttachmentId { get; set; }

		[Required, StringLength(100)]
		public string Name { get; set; }

		public byte[] Content { get; set; }

		public string AttachmentFile { get; set; }

		public string ContentType { get; set; }

		[ForeignKey("Step")]
		public int StepId { get; set; }
		public virtual TestCaseStep Step { get; set; }
	}
}