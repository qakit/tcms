using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Index(nameof(Name), nameof(ProductId), IsUnique = true)]
	[Table("Components", Schema = "core")]
	public class Component : BaseEntity
	{
		public int ComponentId { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(500)]
		public string Description { get; set; }

		[ForeignKey("Product")]
		public int ProductId { get; set; }
		public Product Product { get; set; }

		public virtual ICollection<TestCase> TestCases { get; set; }
	}
}