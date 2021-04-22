using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using tcms.Data.Models;

namespace tcms.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		private readonly IHttpContextAccessor httpContextAccessor;

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
		{
			this.httpContextAccessor = httpContextAccessor;
		}

		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//Product
			modelBuilder.Entity<Product>()
				.HasMany(p => p.Components)
				.WithOne(c => c.Product)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Product>()
				.HasMany(p => p.Versions)
				.WithOne(v => v.Product)
				.OnDelete(DeleteBehavior.Cascade);

			//Component
			modelBuilder.Entity<Component>()
				.HasOne(c => c.Product)
				.WithMany(p => p.Components)
				.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Component>()
				.HasMany(c => c.TestCases)
				.WithOne(tc => tc.Component)
				.OnDelete(DeleteBehavior.Restrict);

			//ProductVersion
			modelBuilder.Entity<ProductVersion>()
				.HasOne(pv => pv.Product)
				.WithMany(p => p.Versions)
				.OnDelete(DeleteBehavior.NoAction);

			//TestCasePriority
			modelBuilder.Entity<TestCasePriority>()
				.HasMany(tcp => tcp.TestCases)
				.WithOne(p => p.Priority)
				.OnDelete(DeleteBehavior.Restrict);

			//TestCaseStatus
			modelBuilder.Entity<TestCaseStatus>()
				.HasMany(tcs => tcs.TestCases)
				.WithOne(p => p.Status)
				.OnDelete(DeleteBehavior.Restrict);

			//TestCaseStep
			//modelBuilder.Entity<TestCaseStep>()
			//	.HasMany(tcs => tcs.Attachments)
			//	.WithOne(tcs => )
			//	.OnDelete(DeleteBehavior.Restrict);

			//TestCaseType
			modelBuilder.Entity<TestCaseType>()
				.HasMany(tct => tct.TestCases)
				.WithOne(p => p.Type)
				.OnDelete(DeleteBehavior.Restrict);

			DatabaseSeed(modelBuilder);
		}

		private void DatabaseSeed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TestCasePriority>().HasData(
				new TestCasePriority { TestCasePriorityId = 3, Name = "Low" },
				new TestCasePriority { TestCasePriorityId = 2, Name = "Medium" },
				new TestCasePriority { TestCasePriorityId = 1, Name = "High" });

			modelBuilder.Entity<TestCaseStatus>().HasData(
				new TestCaseStatus { TestCaseStatusId = 3, Name = "Approved", IsApproved = true },
				new TestCaseStatus { TestCaseStatusId = 1, Name = "Proposed" },
				new TestCaseStatus { TestCaseStatusId = 2, Name = "RequireChanges" });

			modelBuilder.Entity<TestCaseType>().HasData(
				new TestCaseType { TestCaseTypeId = 1, Name = "Functional" },
				new TestCaseType { TestCaseTypeId = 2, Name = "Usability" },
				new TestCaseType { TestCaseTypeId = 3, Name = "Performance" },
				new TestCaseType { TestCaseTypeId = 4, Name = "Regression" });
		}

		public override int SaveChanges()
		{
			AddTimestamps();
			return base.SaveChanges();
		}

		private void AddTimestamps()
		{
			ChangeTracker.DetectChanges();

			var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

			var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

			var currentUsername = !string.IsNullOrEmpty(userId)
				? userId
				: "Anonymous";

			foreach (var entity in entities)
			{
				if (entity.State == EntityState.Added)
				{
					((BaseEntity)entity.Entity).CreatedDate = DateTime.UtcNow;
					((BaseEntity)entity.Entity).CreatedBy = currentUsername;
				}

				((BaseEntity)entity.Entity).ModifiedDate = DateTime.UtcNow;
				((BaseEntity)entity.Entity).ModifiedBy = currentUsername;
			}
		}
	}
}