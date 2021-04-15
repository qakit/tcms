using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tcms.Data.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		
		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(500)]
		public string Description { get; set; }

		public virtual ICollection<ProductVersion> Versions { get; set; }

		public virtual ICollection<Component> Components { get; set; }
	}
}
