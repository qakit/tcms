using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;
using tcms.Areas.Identity;
using tcms.Constants;
using tcms.Data;

namespace tcms
{
    public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMudServices();
			// services.AddDbContext<ApplicationDbContext>(options =>  // TODO should be removed?
			//     options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
			services.AddDbContextFactory<ApplicationDbContext>(options =>
				options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")))
				.AddTransient<DatabaseSeeder>();
			
			services.AddScoped<ApplicationDbContext>(p => 
				p.GetRequiredService<IDbContextFactory<ApplicationDbContext>>()
				.CreateDbContext());
			services.AddIdentity<IdentityUser, IdentityRole>(config =>
				{
					config.SignIn.RequireConfirmedEmail = true; //optional
				})
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders()
				.AddDefaultUI()
				;

			services.AddLocalization(options =>
			{
				options.ResourcesPath = "Resources";
			});

			services.AddAuthorization(options => {
				foreach(var p in Services.PermissionsHelper.AllPermissions)
				{
					// create policies named after respective permission name. Policy required claim to be granted
					options.AddPolicy(p, policy => policy.RequireClaim(ApplicationClaimTypes.Permission, p));
				}
				options.AddPolicy("AnyAdminPrivilege", policy => policy.RequireClaim(ApplicationClaimTypes.Permission, Permissions.Admin.ManageUsers, Permissions.Admin.ManageProducts));
			});
			services.AddSingleton<IClaimsTransformation, ClaimsTransformer>();

			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
			services.AddDatabaseDeveloperPageExceptionFilter();
			services.AddHttpContextAccessor();
			services.AddTransient<ClaimsPrincipal>(s =>
    			s.GetService<IHttpContextAccessor>().HttpContext.User);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});

			app.Initialize();
		}
	}
}
