using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }
		[StringLength(50)]
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		public byte[] Avatar { get; set; }

		[InverseProperty("CreatedBy")]
		public ICollection<TestCase> CreatedTestCases { get; set; }
		[InverseProperty("EditedBy")]
		public ICollection<TestCase> EditedTestCases { get; set; }
	}
}
