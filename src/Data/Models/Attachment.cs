using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class Attachment
	{
		[Key]
		public int AttachmentId { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		public byte[] Content { get; set; }

		[ForeignKey("TestCaseStepId")]
		public virtual TestCaseStep Step { get; set; }
	}
}