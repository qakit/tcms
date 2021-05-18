using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using tcms.Constants;

namespace tcms.Services
{
	public static class PermissionsHelper
	{
		public static readonly IReadOnlyCollection<string> AllPermissions = 
			new List<string>(
				Enumerable.Empty<string>()
					.Concat(GetPermissions(typeof(Permissions.Admin)))
					.Concat(GetPermissions(typeof(Permissions.TestCases)))
					.Concat(GetPermissions(typeof(Permissions.TestPlan)))
			).AsReadOnly();
		
		public static IEnumerable<string> GetPermissions(Type policy)
		{
			var fields = policy.GetFields(BindingFlags.Static | BindingFlags.Public);
			foreach (FieldInfo fi in fields)
			{
				yield return fi.GetValue(null).ToString();
			}
		}
	}
}