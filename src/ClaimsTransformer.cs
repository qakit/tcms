using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using tcms.Constants;

namespace tcms
{
	public class ClaimsTransformer : IClaimsTransformation
	{
		private readonly IConfiguration _configuration;

		public ClaimsTransformer(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
		{
			var claimsIdentity = (ClaimsIdentity)principal.Identity;
			System.Console.WriteLine($"Probing {principal.Identity.Name}");
			if (principal.IsInRole(Constants.UserRoleConstants.AdministratorRole))
			{
				System.Console.WriteLine($"{principal.Identity.Name}: ADMIN role detected");
				var allPermissions = Services.PermissionsHelper.AllPermissions;

				foreach (var item in allPermissions)
				{
					var customRoleClaim = new Claim(ApplicationClaimTypes.Permission, item);
					claimsIdentity.AddClaim(customRoleClaim);
				}
			}

			return Task.FromResult(principal);
		}
	}
}
