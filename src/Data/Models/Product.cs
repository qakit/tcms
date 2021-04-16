using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[AdaptTo("[name]Dto")]
	[Table("Products", Schema = "core")]
	[Index(nameof(Name), IsUnique = true)]
	public class Product : BaseEntity
	{
		public int ProductId { get; set; }
		
		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(500)]
		public string Description { get; set; }

		[AdaptIgnore]
		public virtual ICollection<ProductVersion> Versions { get; set; }

		[AdaptIgnore]
		public virtual ICollection<Component> Components { get; set; }
	}
}
