using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace tcms.Data
{
	public class DatabaseSeeder
	{
		// private readonly UserManager _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public DatabaseSeeder(RoleManager<IdentityRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public void Initialize()
		{
			Task.Run(async () => {
				await InitRoles();
			}).GetAwaiter().GetResult();
		}

		private async Task InitRoles()
		{
			var rolesInitialized = _roleManager.Roles.Count() > 0;
			if(!rolesInitialized)
			{
				await _roleManager.CreateAsync(new IdentityRole("Administrator"));
				await _roleManager.CreateAsync(new IdentityRole("Test manager"));
				await _roleManager.CreateAsync(new IdentityRole("Tester"));
			}
		}
	}
}