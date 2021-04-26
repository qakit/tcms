﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using tcms.Data;

namespace tcms.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("tcms.Data.Models.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AttachmentFile")
                        .HasColumnType("text");

                    b.Property<byte[]>("Content")
                        .HasColumnType("bytea");

                    b.Property<string>("ContentType")
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("TestCaseStepId")
                        .HasColumnType("integer");

                    b.HasKey("AttachmentId");

                    b.HasIndex("TestCaseStepId");

                    b.ToTable("Attachments", "core");
                });

            modelBuilder.Entity("tcms.Data.Models.Component", b =>
                {
                    b.Property<int>("ComponentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("ComponentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("Name", "ProductId")
                        .IsUnique();

                    b.ToTable("Components", "core");
                });

            modelBuilder.Entity("tcms.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ProductId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products", "core");
                });

            modelBuilder.Entity("tcms.Data.Models.ProductVersion", b =>
                {
                    b.Property<int>("ProductVersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("Date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("Date");

                    b.HasKey("ProductVersionId");

                    b.HasIndex("ProductId");

                    b.HasIndex("Name", "ProductId")
                        .IsUnique();

                    b.ToTable("ProductVersions", "core");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCase", b =>
                {
                    b.Property<int>("TestCaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("ComponentId")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<double>("EstimateHr")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsAutomated")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PriorityTestCasePriorityId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusTestCaseStatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("TypeTestCaseTypeId")
                        .HasColumnType("integer");

                    b.HasKey("TestCaseId");

                    b.HasIndex("ComponentId");

                    b.HasIndex("PriorityTestCasePriorityId");

                    b.HasIndex("StatusTestCaseStatusId");

                    b.HasIndex("TypeTestCaseTypeId");

                    b.ToTable("TestCases", "testcases");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCasePriority", b =>
                {
                    b.Property<int>("TestCasePriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TestCasePriorityId");

                    b.ToTable("Priorities", "testcases");

                    b.HasData(
                        new
                        {
                            TestCasePriorityId = 3,
                            Name = "Low"
                        },
                        new
                        {
                            TestCasePriorityId = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            TestCasePriorityId = 1,
                            Name = "High"
                        });
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseStatus", b =>
                {
                    b.Property<int>("TestCaseStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("TestCaseStatusId");

                    b.ToTable("Statuses", "testcases");

                    b.HasData(
                        new
                        {
                            TestCaseStatusId = 3,
                            IsApproved = true,
                            Name = "Approved"
                        },
                        new
                        {
                            TestCaseStatusId = 1,
                            IsApproved = false,
                            Name = "Proposed"
                        },
                        new
                        {
                            TestCaseStatusId = 2,
                            IsApproved = false,
                            Name = "RequireChanges"
                        });
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseStep", b =>
                {
                    b.Property<int>("TestCaseStepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsPrecondition")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Ordinal")
                        .HasColumnType("integer");

                    b.Property<int>("TestCaseId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TestCaseStepId");

                    b.HasIndex("TestCaseId");

                    b.ToTable("Steps", "testcases");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseType", b =>
                {
                    b.Property<int>("TestCaseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("TestCaseTypeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Types", "testcases");

                    b.HasData(
                        new
                        {
                            TestCaseTypeId = 1,
                            Name = "Functional"
                        },
                        new
                        {
                            TestCaseTypeId = 2,
                            Name = "Usability"
                        },
                        new
                        {
                            TestCaseTypeId = 3,
                            Name = "Performance"
                        },
                        new
                        {
                            TestCaseTypeId = 4,
                            Name = "Regression"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tcms.Data.Models.Attachment", b =>
                {
                    b.HasOne("tcms.Data.Models.TestCaseStep", null)
                        .WithMany("Attachments")
                        .HasForeignKey("TestCaseStepId");
                });

            modelBuilder.Entity("tcms.Data.Models.Component", b =>
                {
                    b.HasOne("tcms.Data.Models.Product", "Product")
                        .WithMany("Components")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("tcms.Data.Models.ProductVersion", b =>
                {
                    b.HasOne("tcms.Data.Models.Product", "Product")
                        .WithMany("Versions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCase", b =>
                {
                    b.HasOne("tcms.Data.Models.Component", "Component")
                        .WithMany("TestCases")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("tcms.Data.Models.TestCasePriority", "Priority")
                        .WithMany("TestCases")
                        .HasForeignKey("PriorityTestCasePriorityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("tcms.Data.Models.TestCaseStatus", "Status")
                        .WithMany("TestCases")
                        .HasForeignKey("StatusTestCaseStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("tcms.Data.Models.TestCaseType", "Type")
                        .WithMany("TestCases")
                        .HasForeignKey("TypeTestCaseTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Component");

                    b.Navigation("Priority");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseStep", b =>
                {
                    b.HasOne("tcms.Data.Models.TestCase", "TestCase")
                        .WithMany("Steps")
                        .HasForeignKey("TestCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestCase");
                });

            modelBuilder.Entity("tcms.Data.Models.Component", b =>
                {
                    b.Navigation("TestCases");
                });

            modelBuilder.Entity("tcms.Data.Models.Product", b =>
                {
                    b.Navigation("Components");

                    b.Navigation("Versions");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCase", b =>
                {
                    b.Navigation("Steps");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCasePriority", b =>
                {
                    b.Navigation("TestCases");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseStatus", b =>
                {
                    b.Navigation("TestCases");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseStep", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("tcms.Data.Models.TestCaseType", b =>
                {
                    b.Navigation("TestCases");
                });
#pragma warning restore 612, 618
        }
    }
}
