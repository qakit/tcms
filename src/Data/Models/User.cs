using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class User : IdentityUser
	{
		[InverseProperty("CreatedBy")]
		public ICollection<TestCase> CreatedTestCases { get; set; }

		[InverseProperty("EditedBy")]
		public ICollection<TestCase> EditedTestCases { get; set; }
	}
}