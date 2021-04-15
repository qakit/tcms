using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("ProductVersions", Schema = "core")]
	public class ProductVersion : BaseEntity
	{
		public int ProductVersionId { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(250)]
		public string Description { get; set; }

		[Column(TypeName ="Date")]
		public DateTime StartDate { get; set; }

		[Column(TypeName = "Date")]
		public DateTime EndDate { get; set; }

		public bool IsActive { get; set; }

		[ForeignKey("Product")]
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}