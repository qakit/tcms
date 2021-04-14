using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcms.Data.Models
{
	public class TestCaseStep
	{
		[Key]
		public int TestCaseStepId { get; set; }
		public string Description { get; set; }
		//Do we need it? E.g. to show correctly in UI
		public bool IsPrecondition { get; set; } = false;

		[ForeignKey("TestCaseId")]
		public virtual TestCase TestCase { get; set; }
	}
}
