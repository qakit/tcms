using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapster;

namespace tcms.Data.Models
{
	public class BaseEntity
	{
		[AdaptIgnore(MemberSide.Destination)]
		public DateTime? CreatedDate { get; set; }

		[AdaptIgnore(MemberSide.Destination)]
		public DateTime? ModifiedDate { get; set; }

		[AdaptIgnore(MemberSide.Destination)]
		[Column("CreatedBy")]
		[Display(Name = "Creator")]
		public string CreatedBy { get; set; }

		[AdaptIgnore(MemberSide.Destination)]
		[Column("ModifiedBy")]
		[Display(Name = "Modifier")]
		public string ModifiedBy { get; set; }
	}
}