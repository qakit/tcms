using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using tcms.Constants;

namespace tcms.Data
{
	public class DatabaseSeeder
	{
		// private readonly UserManager _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UserManager<IdentityUser> _userManager;
		private readonly ILogger<DatabaseSeeder> _logger;


        public DatabaseSeeder(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ILogger<DatabaseSeeder> logger)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _logger = logger;
        }

        public void Initialize()
		{
			Task.Run(async () => {
				await InitRoles();
				await InitUsers();
			}).GetAwaiter().GetResult();
		}

		private async Task InitRoles()
		{
			var rolesInitialized = _roleManager.Roles.Count() > 0;
			if(!rolesInitialized)
			{
				await _roleManager.CreateAsync(new IdentityRole(UserRoleConstants.AdministratorRole));
				await _roleManager.CreateAsync(new IdentityRole(UserRoleConstants.TestManagerRole));
				await _roleManager.CreateAsync(new IdentityRole(UserRoleConstants.TesterRole));
			}
		}

		private async Task InitUsers()
		{
			var usersToCreate = new[] {
				new { name = "admin", role = UserRoleConstants.AdministratorRole},
				new { name = "testman", role = UserRoleConstants.TestManagerRole},
				new { name = "tester", role = UserRoleConstants.TesterRole},
			};

			foreach(var template in usersToCreate)
			{
				var newUser = new IdentityUser
				{
					UserName = $"{template.name}@tcms",
					Email = $"{template.name}@tcms.dataworks.co",
					EmailConfirmed = true,
					PhoneNumberConfirmed = true,
				};
				var userInDb = await _userManager.FindByEmailAsync(newUser.Email);
				if (userInDb == null)
				{
					await _userManager.CreateAsync(newUser, UserRoleConstants.DefaultPassword);
					var result = await _userManager.AddToRoleAsync(newUser, template.role);
					if(result.Succeeded)
					{
						_logger.LogInformation($"Seeded user \"${newUser.UserName}\" with \"${template.role}\" role.");
					}
				}
			}
		}
	}
}