using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using MudBlazor;
using tcms.Constants;

namespace tcms.Pages.Identity
{
	public partial class RoleModal
	{
		[Inject]
		RoleManager<IdentityRole> roleManager  { get; set; }

		private bool success;
		private string[] errors = { };
		private MudForm form;

		[Parameter]
		public string Id { get; set; }

		[Parameter]
		[Required]
		public string Name { get; set; }

		[CascadingParameter] private MudDialogInstance MudDialog { get; set; }

		public void Cancel()
		{
			MudDialog.Cancel();
		}
		private async Task SaveAsync()
		{
			form.Validate();
			if (form.IsValid)
			{
				var isNew = Id == null;
				IdentityResult response;
				if (isNew)
				{
					response = await roleManager.CreateAsync(new IdentityRole(Name));
				}
				else
				{
					var existingRole = await roleManager.FindByIdAsync(Id);
					if (existingRole.Name == UserRoleConstants.AdministratorRole)
					{
						_snackBar.Add("Cannot update builtin role", Severity.Error);
						return;
					}
					existingRole.Name = Name;
					existingRole.NormalizedName = Name.ToUpper();

					response = await roleManager.UpdateAsync(existingRole);
				}
				if (response.Succeeded)
				{
					_snackBar.Add("Role created/updated", Severity.Success);
					MudDialog.Close();
				}
				else
				{
					foreach (var message in response.Errors)
					{
						_snackBar.Add(message.Description, Severity.Error);
					}
				}
			}
		}
	}
}