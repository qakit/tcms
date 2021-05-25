namespace tcms.Constants
{
    public static class Permissions
	{
		public static class TestPlan
		{
			public const string Assign = "TestPlan.Assign";
			public const string Exec = "TestPlan.Exec"; // assign himself and execute
			public const string Create = "TestPlan.Create"; // create/edit
		}
		public static class TestCases
		{
			public const string Edit = "TestCase.Edit"; // can add/edit non-approved test cases
			public const string Delete = "TestCase.Delete"; // can delete (cascade delete from test plans)
			public const string Approve = "TestCase.Approve";
			// public const string Tag = "TestCase.Tag";
			// public const string EditApproved = "TestCase.EditApproved";
			// we allow to edit approved cases, but system will automatically reset "Approved" status
		}

		public static class Admin
		{
			public const string ManageProducts = "ManageProducts";
			public const string ManageUsers = "ManageUsers";
			public const string ViewRoles = "ViewRoles";
		}
	}
}
