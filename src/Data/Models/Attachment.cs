using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("Attachments", Schema = "core")]
	public class Attachment : BaseEntity
	{
		public int AttachmentId { get; set; }

		[Required, StringLength(100)]
		public string Name { get; set; }

		public byte[] Content { get; set; }

		public string AttachmentFile { get; set; }

		public string ContentType { get; set; }
	}
}