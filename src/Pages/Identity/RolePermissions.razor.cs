using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using MudBlazor;
using tcms.Constants;

namespace tcms.Pages.Identity
{
	public partial class RolePermissions
	{
		public class RoleClaim
		{
			public string Type { get; set; }
			public string Value { get; set; }
			public bool Selected { get; set; }
		}

		[Inject] Microsoft.AspNetCore.Components.NavigationManager _navigationManager { get; set; }
		[Inject] RoleManager<IdentityRole> _roleManager  { get; set; }

		[Parameter]
		public string Id { get; set; }

		[Parameter]
		public string Description { get; set; }

		public List<RoleClaim> RoleClaims { get; set; }

		private readonly IReadOnlyCollection<string> AllPermissions = 
			new List<string>(
				Enumerable.Empty<string>()
					.Concat(GetPermissions(typeof(Permissions.Admin)))
					.Concat(GetPermissions(typeof(Permissions.TestCases)))
					.Concat(GetPermissions(typeof(Permissions.TestPlan)))
			).AsReadOnly();
		
		public static IEnumerable<string> GetPermissions(Type policy)
		{
			FieldInfo[] fields = policy.GetFields(BindingFlags.Static | BindingFlags.Public);
			foreach (FieldInfo fi in fields)
			{
				yield return fi.GetValue(null).ToString();
			}
		}

		protected override async Task OnInitializedAsync()
		{
			var roleId = Id;
			var role = await _roleManager.FindByIdAsync(roleId);
			var claims = await _roleManager.GetClaimsAsync(role);
			if (claims != null)
			{
				RoleClaims = (from p in AllPermissions
					select new RoleClaim { Type = "Permission", Value = p, Selected = claims.Any(c => c.Value == p) }
				).ToList();
				if (RoleClaims.Any())
				{
					Description = $"Manage {role.Name}'s Permissions";
				}
			}
		}
		private async Task SaveAsync()
		{
			var role = await _roleManager.FindByIdAsync(Id);
			var claims = await _roleManager.GetClaimsAsync(role);

			var removeClaims = (
				from rc in RoleClaims join claim in claims on rc.Value equals claim.Value
				where !rc.Selected && claim.Type == "Permission"
				select claim).ToList();
			var newClaims = (
				from rc in RoleClaims
				where rc.Selected
				where !claims.Any(claim => claim.Value == rc.Value && claim.Type == "Permission")
				select new Claim("Permission", rc.Value)).ToList();

			var failures = new List<IdentityResult>();
			int updateCount = 0;
			foreach(var removeClaim in removeClaims) {
				var result = await _roleManager.RemoveClaimAsync(role, removeClaim);
				if(!result.Succeeded) failures.Add(result);
				else updateCount++;
			}
			foreach(var newClaim in newClaims) {
				var result = await _roleManager.AddClaimAsync(role, newClaim);
				if(!result.Succeeded) failures.Add(result);
				else updateCount++;
			}
			if (!failures.Any())
			{
				if(updateCount > 0)
					_snackBar.Add($"Updated {updateCount} permission records", Severity.Success);
				_navigationManager.NavigateTo("/identity/roles");
			}
			else
			{
				foreach (var error in from f in failures from e in f.Errors select e)
				{
					_snackBar.Add(error.Description, Severity.Error);
				}
			}
		}
	}
}