﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	[Table("Products", Schema = "core")]
	[Index(nameof(Name), IsUnique = true)]
	public class Product : BaseEntity
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
