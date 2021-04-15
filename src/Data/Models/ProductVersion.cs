using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class ProductVersion
	{
		public int ProductVersionId { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(250)]
		public string Description { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public bool IsActive { get; set; }

		[ForeignKey("Product")]
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}