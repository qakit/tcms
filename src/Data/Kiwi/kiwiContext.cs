using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class kiwiContext : DbContext
    {
        public kiwiContext()
        {
        }

        public kiwiContext(DbContextOptions<kiwiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttachmentsAttachment> AttachmentsAttachments { get; set; }
        public virtual DbSet<AuthGroup> AuthGroups { get; set; }
        public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual DbSet<AuthPermission> AuthPermissions { get; set; }
        public virtual DbSet<AuthUser> AuthUsers { get; set; }
        public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual DbSet<BugsBug> BugsBugs { get; set; }
        public virtual DbSet<BugsBugExecution> BugsBugExecutions { get; set; }
        public virtual DbSet<BugsBugTag> BugsBugTags { get; set; }
        public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual DbSet<DjangoComment> DjangoComments { get; set; }
        public virtual DbSet<DjangoCommentFlag> DjangoCommentFlags { get; set; }
        public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }
        public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }
        public virtual DbSet<DjangoSession> DjangoSessions { get; set; }
        public virtual DbSet<DjangoSite> DjangoSites { get; set; }
        public virtual DbSet<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }
        public virtual DbSet<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }
        public virtual DbSet<KiwiAuthUseractivationkey> KiwiAuthUseractivationkeys { get; set; }
        public virtual DbSet<LinkreferenceLinkreference> LinkreferenceLinkreferences { get; set; }
        public virtual DbSet<ManagementBuild> ManagementBuilds { get; set; }
        public virtual DbSet<ManagementClassification> ManagementClassifications { get; set; }
        public virtual DbSet<ManagementComponent> ManagementComponents { get; set; }
        public virtual DbSet<ManagementPriority> ManagementPriorities { get; set; }
        public virtual DbSet<ManagementProduct> ManagementProducts { get; set; }
        public virtual DbSet<ManagementTag> ManagementTags { get; set; }
        public virtual DbSet<ManagementVersion> ManagementVersions { get; set; }
        public virtual DbSet<TestcasesBugsystem> TestcasesBugsystems { get; set; }
        public virtual DbSet<TestcasesCategory> TestcasesCategories { get; set; }
        public virtual DbSet<TestcasesHistoricaltestcase> TestcasesHistoricaltestcases { get; set; }
        public virtual DbSet<TestcasesTestcase> TestcasesTestcases { get; set; }
        public virtual DbSet<TestcasesTestcasecomponent> TestcasesTestcasecomponents { get; set; }
        public virtual DbSet<TestcasesTestcaseemailsetting> TestcasesTestcaseemailsettings { get; set; }
        public virtual DbSet<TestcasesTestcaseplan> TestcasesTestcaseplans { get; set; }
        public virtual DbSet<TestcasesTestcasestatus> TestcasesTestcasestatuses { get; set; }
        public virtual DbSet<TestcasesTestcasetag> TestcasesTestcasetags { get; set; }
        public virtual DbSet<TestplansHistoricaltestplan> TestplansHistoricaltestplans { get; set; }
        public virtual DbSet<TestplansPlantype> TestplansPlantypes { get; set; }
        public virtual DbSet<TestplansTestplan> TestplansTestplans { get; set; }
        public virtual DbSet<TestplansTestplanemailsetting> TestplansTestplanemailsettings { get; set; }
        public virtual DbSet<TestplansTestplantag> TestplansTestplantags { get; set; }
        public virtual DbSet<TestrunsHistoricaltestexecution> TestrunsHistoricaltestexecutions { get; set; }
        public virtual DbSet<TestrunsHistoricaltestrun> TestrunsHistoricaltestruns { get; set; }
        public virtual DbSet<TestrunsTestexecution> TestrunsTestexecutions { get; set; }
        public virtual DbSet<TestrunsTestexecutionstatus> TestrunsTestexecutionstatuses { get; set; }
        public virtual DbSet<TestrunsTestrun> TestrunsTestruns { get; set; }
        public virtual DbSet<TestrunsTestruncc> TestrunsTestrunccs { get; set; }
        public virtual DbSet<TestrunsTestruntag> TestrunsTestruntags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=kiwi;Username=kiwi;Password=kiwi");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<AttachmentsAttachment>(entity =>
            {
                entity.ToTable("attachments_attachment");

                entity.HasIndex(e => e.ContentTypeId, "attachments_attachment_content_type_id_35dd9d5d");

                entity.HasIndex(e => e.Created, "attachments_attachment_created_96fbcd43");

                entity.HasIndex(e => e.CreatorId, "attachments_attachment_creator_id_d471ef83");

                entity.HasIndex(e => e.Modified, "attachments_attachment_modified_1d39a3d7");

                entity.HasIndex(e => e.ObjectId, "attachments_attachment_object_id_102ce831");

                entity.HasIndex(e => e.ObjectId, "attachments_attachment_object_id_102ce831_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttachmentFile)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("attachment_file");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Created)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Modified)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("modified");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("object_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AttachmentsAttachments)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attachments_attachme_content_type_id_35dd9d5d_fk_django_co");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.AttachmentsAttachments)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attachments_attachment_creator_id_d471ef83_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group");

                entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "auth_group_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AuthGroupPermission>(entity =>
            {
                entity.ToTable("auth_group_permissions");

                entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission");

                entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("codename");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AuthPermissions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.ToTable("auth_user");

                entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Username, "auth_user_username_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateJoined)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("date_joined");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("last_login");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AuthUserGroup>(entity =>
            {
                entity.ToTable("auth_user_groups");

                entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

                entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthUserUserPermission>(entity =>
            {
                entity.ToTable("auth_user_user_permissions");

                entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
            });

            modelBuilder.Entity<BugsBug>(entity =>
            {
                entity.ToTable("bugs_bug");

                entity.HasIndex(e => e.AssigneeId, "bugs_bug_assignee_id_2006cbf7");

                entity.HasIndex(e => e.BuildId, "bugs_bug_build_id_f3b6bc1b");

                entity.HasIndex(e => e.CreatedAt, "bugs_bug_created_at_f132529e");

                entity.HasIndex(e => e.ProductId, "bugs_bug_product_id_a052f422");

                entity.HasIndex(e => e.ReporterId, "bugs_bug_reporter_id_f3c433c0");

                entity.HasIndex(e => e.Status, "bugs_bug_status_3e54f71f");

                entity.HasIndex(e => e.Summary, "bugs_bug_summary_8321d37f");

                entity.HasIndex(e => e.Summary, "bugs_bug_summary_8321d37f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.VersionId, "bugs_bug_version_id_9e5c9e9d");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssigneeId).HasColumnName("assignee_id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ReporterId).HasColumnName("reporter_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("summary");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.HasOne(d => d.Assignee)
                    .WithMany(p => p.BugsBugAssignees)
                    .HasForeignKey(d => d.AssigneeId)
                    .HasConstraintName("bugs_bug_assignee_id_2006cbf7_fk_auth_user_id");

                entity.HasOne(d => d.Build)
                    .WithMany(p => p.BugsBugs)
                    .HasForeignKey(d => d.BuildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_build_id_f3b6bc1b_fk_management_build_build_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BugsBugs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_product_id_a052f422_fk_management_product_id");

                entity.HasOne(d => d.Reporter)
                    .WithMany(p => p.BugsBugReporters)
                    .HasForeignKey(d => d.ReporterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_reporter_id_f3c433c0_fk_auth_user_id");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.BugsBugs)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_version_id_9e5c9e9d_fk_management_version_id");
            });

            modelBuilder.Entity<BugsBugExecution>(entity =>
            {
                entity.ToTable("bugs_bug_executions");

                entity.HasIndex(e => e.BugId, "bugs_bug_executions_bug_id_3a87c570");

                entity.HasIndex(e => new { e.BugId, e.TestexecutionId }, "bugs_bug_executions_bug_id_testexecution_id_0fd55cb1_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.TestexecutionId, "bugs_bug_executions_testexecution_id_b835d93d");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BugId).HasColumnName("bug_id");

                entity.Property(e => e.TestexecutionId).HasColumnName("testexecution_id");

                entity.HasOne(d => d.Bug)
                    .WithMany(p => p.BugsBugExecutions)
                    .HasForeignKey(d => d.BugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_executions_bug_id_3a87c570_fk_bugs_bug_id");

                entity.HasOne(d => d.Testexecution)
                    .WithMany(p => p.BugsBugExecutions)
                    .HasForeignKey(d => d.TestexecutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_executions_testexecution_id_b835d93d_fk_testruns_");
            });

            modelBuilder.Entity<BugsBugTag>(entity =>
            {
                entity.ToTable("bugs_bug_tags");

                entity.HasIndex(e => e.BugId, "bugs_bug_tags_bug_id_d465bac2");

                entity.HasIndex(e => new { e.BugId, e.TagId }, "bugs_bug_tags_bug_id_tag_id_e88c85cd_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.TagId, "bugs_bug_tags_tag_id_c3ddee2f");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BugId).HasColumnName("bug_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Bug)
                    .WithMany(p => p.BugsBugTags)
                    .HasForeignKey(d => d.BugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_tags_bug_id_d465bac2_fk_bugs_bug_id");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.BugsBugTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bugs_bug_tags_tag_id_c3ddee2f_fk_management_tag_tag_id");
            });

            modelBuilder.Entity<DjangoAdminLog>(entity =>
            {
                entity.ToTable("django_admin_log");

                entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

                entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFlag).HasColumnName("action_flag");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("action_time");

                entity.Property(e => e.ChangeMessage)
                    .IsRequired()
                    .HasColumnName("change_message");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectRepr)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("object_repr");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoComment>(entity =>
            {
                entity.ToTable("django_comments");

                entity.HasIndex(e => e.ContentTypeId, "django_comments_content_type_id_c4afe962");

                entity.HasIndex(e => e.SiteId, "django_comments_site_id_9dcf666e");

                entity.HasIndex(e => e.SubmitDate, "django_comments_submit_date_514ed2d9");

                entity.HasIndex(e => e.UserId, "django_comments_user_id_a0a440a1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.IpAddress).HasColumnName("ip_address");

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.IsRemoved).HasColumnName("is_removed");

                entity.Property(e => e.ObjectPk)
                    .IsRequired()
                    .HasColumnName("object_pk");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.SubmitDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("submit_date");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("user_url");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoComments)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_comments_content_type_id_c4afe962_fk_django_co");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.DjangoComments)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_comments_site_id_9dcf666e_fk_django_site_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoComments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("django_comments_user_id_a0a440a1_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoCommentFlag>(entity =>
            {
                entity.ToTable("django_comment_flags");

                entity.HasIndex(e => e.CommentId, "django_comment_flags_comment_id_d8054933");

                entity.HasIndex(e => e.Flag, "django_comment_flags_flag_8b141fcb");

                entity.HasIndex(e => e.Flag, "django_comment_flags_flag_8b141fcb_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => new { e.UserId, e.CommentId, e.Flag }, "django_comment_flags_user_id_comment_id_flag_537f77a7_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "django_comment_flags_user_id_f3f81f0a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("flag");

                entity.Property(e => e.FlagDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("flag_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.DjangoCommentFlags)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_comment_flags_comment_id_d8054933_fk_django_comments_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoCommentFlags)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_comment_flags_user_id_f3f81f0a_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoContentType>(entity =>
            {
                entity.ToTable("django_content_type");

                entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("app_label");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<DjangoMigration>(entity =>
            {
                entity.ToTable("django_migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("app");

                entity.Property(e => e.Applied)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("applied");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DjangoSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("django_session_pkey");

                entity.ToTable("django_session");

                entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

                entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(40)
                    .HasColumnName("session_key");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("expire_date");

                entity.Property(e => e.SessionData)
                    .IsRequired()
                    .HasColumnName("session_data");
            });

            modelBuilder.Entity<DjangoSite>(entity =>
            {
                entity.ToTable("django_site");

                entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("domain");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<GuardianGroupobjectpermission>(entity =>
            {
                entity.ToTable("guardian_groupobjectpermission");

                entity.HasIndex(e => new { e.ContentTypeId, e.ObjectPk }, "guardian_gr_content_ae6aec_idx");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId, e.ObjectPk }, "guardian_groupobjectperm_group_id_permission_id_o_3f189f7c_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.ContentTypeId, "guardian_groupobjectpermission_content_type_id_7ade36b8");

                entity.HasIndex(e => e.GroupId, "guardian_groupobjectpermission_group_id_4bbbfb62");

                entity.HasIndex(e => e.PermissionId, "guardian_groupobjectpermission_permission_id_36572738");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ObjectPk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("object_pk");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.GuardianGroupobjectpermissions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("guardian_groupobject_content_type_id_7ade36b8_fk_django_co");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GuardianGroupobjectpermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("guardian_groupobject_group_id_4bbbfb62_fk_auth_grou");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.GuardianGroupobjectpermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("guardian_groupobject_permission_id_36572738_fk_auth_perm");
            });

            modelBuilder.Entity<GuardianUserobjectpermission>(entity =>
            {
                entity.ToTable("guardian_userobjectpermission");

                entity.HasIndex(e => new { e.ContentTypeId, e.ObjectPk }, "guardian_us_content_179ed2_idx");

                entity.HasIndex(e => new { e.UserId, e.PermissionId, e.ObjectPk }, "guardian_userobjectpermi_user_id_permission_id_ob_b0b3d2fc_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.ContentTypeId, "guardian_userobjectpermission_content_type_id_2e892405");

                entity.HasIndex(e => e.PermissionId, "guardian_userobjectpermission_permission_id_71807bfc");

                entity.HasIndex(e => e.UserId, "guardian_userobjectpermission_user_id_d5c1e964");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectPk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("object_pk");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.GuardianUserobjectpermissions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("guardian_userobjectp_content_type_id_2e892405_fk_django_co");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.GuardianUserobjectpermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("guardian_userobjectp_permission_id_71807bfc_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GuardianUserobjectpermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("guardian_userobjectpermission_user_id_d5c1e964_fk_auth_user_id");
            });

            modelBuilder.Entity<KiwiAuthUseractivationkey>(entity =>
            {
                entity.ToTable("kiwi_auth_useractivationkey");

                entity.HasIndex(e => e.UserId, "kiwi_auth_useractivationkey_user_id_cb6f6f73");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivationKey)
                    .HasMaxLength(64)
                    .HasColumnName("activation_key");

                entity.Property(e => e.KeyExpires)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("key_expires");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.KiwiAuthUseractivationkeys)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kiwi_auth_useractivationkey_user_id_cb6f6f73_fk_auth_user_id");
            });

            modelBuilder.Entity<LinkreferenceLinkreference>(entity =>
            {
                entity.ToTable("linkreference_linkreference");

                entity.HasIndex(e => e.CreatedOn, "linkreference_linkreference_created_on_9a8e5281");

                entity.HasIndex(e => e.IsDefect, "linkreference_linkreference_is_defect_1afb0f5c");

                entity.HasIndex(e => e.ExecutionId, "linkreference_linkreference_test_case_run_id_4d6f7698");

                entity.HasIndex(e => e.Url, "linkreference_linkreference_url_a67ef7ca");

                entity.HasIndex(e => e.Url, "linkreference_linkreference_url_a67ef7ca_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_on");

                entity.Property(e => e.ExecutionId).HasColumnName("execution_id");

                entity.Property(e => e.IsDefect).HasColumnName("is_defect");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("url");

                entity.HasOne(d => d.Execution)
                    .WithMany(p => p.LinkreferenceLinkreferences)
                    .HasForeignKey(d => d.ExecutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("linkreference_linkre_execution_id_0f007e30_fk_testruns_");
            });

            modelBuilder.Entity<ManagementBuild>(entity =>
            {
                entity.ToTable("management_build");

                entity.HasIndex(e => e.VersionId, "management_build_version_id_b16465e8");

                entity.HasIndex(e => new { e.VersionId, e.Name }, "management_build_version_id_name_0ca02373_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('management_build_build_id_seq'::regclass)");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.ManagementBuilds)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("management_build_version_id_b16465e8_fk_management_version_id");
            });

            modelBuilder.Entity<ManagementClassification>(entity =>
            {
                entity.ToTable("management_classification");

                entity.HasIndex(e => e.Name, "management_classification_name_fa579c14_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "management_classification_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ManagementComponent>(entity =>
            {
                entity.ToTable("management_component");

                entity.HasIndex(e => e.InitialOwnerId, "management_component_initialowner_1578c4b7");

                entity.HasIndex(e => e.InitialQaContactId, "management_component_initialqacontact_9cfa7629");

                entity.HasIndex(e => e.ProductId, "management_component_product_id_82d6de7e");

                entity.HasIndex(e => new { e.ProductId, e.Name }, "management_component_product_id_name_2bff48aa_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.InitialOwnerId).HasColumnName("initial_owner_id");

                entity.Property(e => e.InitialQaContactId).HasColumnName("initial_qa_contact_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.InitialOwner)
                    .WithMany(p => p.ManagementComponentInitialOwners)
                    .HasForeignKey(d => d.InitialOwnerId)
                    .HasConstraintName("management_component_initial_owner_id_983a4de8_fk_auth_user_id");

                entity.HasOne(d => d.InitialQaContact)
                    .WithMany(p => p.ManagementComponentInitialQaContacts)
                    .HasForeignKey(d => d.InitialQaContactId)
                    .HasConstraintName("management_component_initial_qa_contact_i_00659846_fk_auth_user");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ManagementComponents)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("management_component_product_id_82d6de7e_fk_managemen");
            });

            modelBuilder.Entity<ManagementPriority>(entity =>
            {
                entity.ToTable("management_priority");

                entity.HasIndex(e => e.Value, "management_priority_value_7f0cc2cc_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Value, "management_priority_value_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<ManagementProduct>(entity =>
            {
                entity.ToTable("management_product");

                entity.HasIndex(e => e.ClassificationId, "management_product_classification_id_e4e18e09");

                entity.HasIndex(e => e.Name, "management_product_name_5a40812b_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "management_product_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassificationId).HasColumnName("classification_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Classification)
                    .WithMany(p => p.ManagementProducts)
                    .HasForeignKey(d => d.ClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("management_product_classification_id_e4e18e09_fk_managemen");
            });

            modelBuilder.Entity<ManagementTag>(entity =>
            {
                entity.ToTable("management_tag");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('management_tag_tag_id_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ManagementVersion>(entity =>
            {
                entity.ToTable("management_version");

                entity.HasIndex(e => e.ProductId, "management_version_product_id_f1cf2daf");

                entity.HasIndex(e => new { e.ProductId, e.Value }, "management_version_product_id_value_97d2c1b8_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(192)
                    .HasColumnName("value");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ManagementVersions)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("management_version_product_id_f1cf2daf_fk_management_product_id");
            });

            modelBuilder.Entity<TestcasesBugsystem>(entity =>
            {
                entity.ToTable("testcases_bugsystem");

                entity.HasIndex(e => e.Name, "testcases_bugsystem_name_548a0cab_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "testcases_bugsystem_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiPassword)
                    .HasMaxLength(256)
                    .HasColumnName("api_password");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(1024)
                    .HasColumnName("api_url");

                entity.Property(e => e.ApiUsername)
                    .HasMaxLength(256)
                    .HasColumnName("api_username");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(1024)
                    .HasColumnName("base_url");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.TrackerType)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("tracker_type");
            });

            modelBuilder.Entity<TestcasesCategory>(entity =>
            {
                entity.ToTable("testcases_category");

                entity.HasIndex(e => e.ProductId, "testcases_category_product_id_f26067e7");

                entity.HasIndex(e => new { e.ProductId, e.Name }, "testcases_category_product_id_name_6f991fe0_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testcases_category_category_id_seq'::regclass)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TestcasesCategories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_category_product_id_f26067e7_fk_management_product_id");
            });

            modelBuilder.Entity<TestcasesHistoricaltestcase>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("testcases_historicaltestcase_pkey");

                entity.ToTable("testcases_historicaltestcase");

                entity.HasIndex(e => e.AuthorId, "testcases_historicaltestcase_author_id_0cb2d010");

                entity.HasIndex(e => e.Id, "testcases_historicaltestcase_case_id_5aa11a82");

                entity.HasIndex(e => e.CaseStatusId, "testcases_historicaltestcase_case_status_id_35c6b721");

                entity.HasIndex(e => e.CategoryId, "testcases_historicaltestcase_category_id_05519a7a");

                entity.HasIndex(e => e.DefaultTesterId, "testcases_historicaltestcase_default_tester_id_4096f1c6");

                entity.HasIndex(e => e.HistoryUserId, "testcases_historicaltestcase_history_user_id_7091ce1e");

                entity.HasIndex(e => e.PriorityId, "testcases_historicaltestcase_priority_id_defa02c4");

                entity.HasIndex(e => e.ReviewerId, "testcases_historicaltestcase_reviewer_id_33c64d01");

                entity.HasIndex(e => e.Summary, "testcases_historicaltestcase_summary_92d50821");

                entity.HasIndex(e => e.Summary, "testcases_historicaltestcase_summary_92d50821_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.Arguments).HasColumnName("arguments");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CaseStatusId).HasColumnName("case_status_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("create_date");

                entity.Property(e => e.DefaultTesterId).HasColumnName("default_tester_id");

                entity.Property(e => e.ExtraLink)
                    .HasMaxLength(1024)
                    .HasColumnName("extra_link");

                entity.Property(e => e.HistoryChangeReason).HasColumnName("history_change_reason");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("history_date");

                entity.Property(e => e.HistoryType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("history_type");

                entity.Property(e => e.HistoryUserId).HasColumnName("history_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsAutomated).HasColumnName("is_automated");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PriorityId).HasColumnName("priority_id");

                entity.Property(e => e.Requirement)
                    .HasMaxLength(255)
                    .HasColumnName("requirement");

                entity.Property(e => e.ReviewerId).HasColumnName("reviewer_id");

                entity.Property(e => e.Script).HasColumnName("script");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("summary");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.HasOne(d => d.HistoryUser)
                    .WithMany(p => p.TestcasesHistoricaltestcases)
                    .HasForeignKey(d => d.HistoryUserId)
                    .HasConstraintName("testcases_historical_history_user_id_7091ce1e_fk_auth_user");
            });

            modelBuilder.Entity<TestcasesTestcase>(entity =>
            {
                entity.ToTable("testcases_testcase");

                entity.HasIndex(e => e.AuthorId, "testcases_testcase_author_id_40ee8140");

                entity.HasIndex(e => e.CaseStatusId, "testcases_testcase_case_status_id_506e2b3f");

                entity.HasIndex(e => e.CategoryId, "testcases_testcase_category_id_f52a4b36");

                entity.HasIndex(e => e.DefaultTesterId, "testcases_testcase_default_tester_id_d9c8faf2");

                entity.HasIndex(e => e.PriorityId, "testcases_testcase_priority_id_06e62b85");

                entity.HasIndex(e => e.ReviewerId, "testcases_testcase_reviewer_id_4be5756e");

                entity.HasIndex(e => e.Summary, "testcases_testcase_summary_511d8323");

                entity.HasIndex(e => e.Summary, "testcases_testcase_summary_511d8323_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testcases_testcase_case_id_seq'::regclass)");

                entity.Property(e => e.Arguments).HasColumnName("arguments");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CaseStatusId).HasColumnName("case_status_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("create_date");

                entity.Property(e => e.DefaultTesterId).HasColumnName("default_tester_id");

                entity.Property(e => e.ExtraLink)
                    .HasMaxLength(1024)
                    .HasColumnName("extra_link");

                entity.Property(e => e.IsAutomated).HasColumnName("is_automated");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PriorityId).HasColumnName("priority_id");

                entity.Property(e => e.Requirement)
                    .HasMaxLength(255)
                    .HasColumnName("requirement");

                entity.Property(e => e.ReviewerId).HasColumnName("reviewer_id");

                entity.Property(e => e.Script).HasColumnName("script");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("summary");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TestcasesTestcaseAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcase_author_id_40ee8140_fk_auth_user_id");

                entity.HasOne(d => d.CaseStatus)
                    .WithMany(p => p.TestcasesTestcases)
                    .HasForeignKey(d => d.CaseStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcase_case_status_id_506e2b3f_fk_testcases");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TestcasesTestcases)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcase_category_id_f52a4b36_fk_testcases");

                entity.HasOne(d => d.DefaultTester)
                    .WithMany(p => p.TestcasesTestcaseDefaultTesters)
                    .HasForeignKey(d => d.DefaultTesterId)
                    .HasConstraintName("testcases_testcase_default_tester_id_d9c8faf2_fk_auth_user_id");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.TestcasesTestcases)
                    .HasForeignKey(d => d.PriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcase_priority_id_06e62b85_fk_managemen");

                entity.HasOne(d => d.Reviewer)
                    .WithMany(p => p.TestcasesTestcaseReviewers)
                    .HasForeignKey(d => d.ReviewerId)
                    .HasConstraintName("testcases_testcase_reviewer_id_4be5756e_fk_auth_user_id");
            });

            modelBuilder.Entity<TestcasesTestcasecomponent>(entity =>
            {
                entity.ToTable("testcases_testcasecomponent");

                entity.HasIndex(e => e.CaseId, "testcases_testcasecomponent_case_id_fc27e38a");

                entity.HasIndex(e => e.ComponentId, "testcases_testcasecomponent_component_id_edd78178");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.ComponentId).HasColumnName("component_id");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.TestcasesTestcasecomponents)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcaseco_case_id_fc27e38a_fk_testcases");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.TestcasesTestcasecomponents)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcaseco_component_id_edd78178_fk_managemen");
            });

            modelBuilder.Entity<TestcasesTestcaseemailsetting>(entity =>
            {
                entity.ToTable("testcases_testcaseemailsettings");

                entity.HasIndex(e => e.CaseId, "testcases_testcaseemailsettings_case_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutoToCaseAuthor).HasColumnName("auto_to_case_author");

                entity.Property(e => e.AutoToCaseTester).HasColumnName("auto_to_case_tester");

                entity.Property(e => e.AutoToExecutionAssignee).HasColumnName("auto_to_execution_assignee");

                entity.Property(e => e.AutoToRunManager).HasColumnName("auto_to_run_manager");

                entity.Property(e => e.AutoToRunTester).HasColumnName("auto_to_run_tester");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.CcList)
                    .IsRequired()
                    .HasColumnName("cc_list");

                entity.Property(e => e.NotifyOnCaseDelete).HasColumnName("notify_on_case_delete");

                entity.Property(e => e.NotifyOnCaseUpdate).HasColumnName("notify_on_case_update");

                entity.HasOne(d => d.Case)
                    .WithOne(p => p.TestcasesTestcaseemailsetting)
                    .HasForeignKey<TestcasesTestcaseemailsetting>(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcaseem_case_id_76dfe19b_fk_testcases");
            });

            modelBuilder.Entity<TestcasesTestcaseplan>(entity =>
            {
                entity.ToTable("testcases_testcaseplan");

                entity.HasIndex(e => e.CaseId, "testcases_testcaseplan_case_id_89f638fc");

                entity.HasIndex(e => e.PlanId, "testcases_testcaseplan_plan_id_40b3d762");

                entity.HasIndex(e => new { e.PlanId, e.CaseId }, "testcases_testcaseplan_plan_id_case_id_16d50827_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Sortkey).HasColumnName("sortkey");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.TestcasesTestcaseplans)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcasepl_case_id_89f638fc_fk_testcases");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TestcasesTestcaseplans)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcasepl_plan_id_40b3d762_fk_testplans");
            });

            modelBuilder.Entity<TestcasesTestcasestatus>(entity =>
            {
                entity.ToTable("testcases_testcasestatus");

                entity.HasIndex(e => e.IsConfirmed, "testcases_testcasestatus_is_confirmed_ba7f915d");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testcases_testcasestatus_case_status_id_seq'::regclass)");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsConfirmed).HasColumnName("is_confirmed");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TestcasesTestcasetag>(entity =>
            {
                entity.ToTable("testcases_testcasetag");

                entity.HasIndex(e => e.CaseId, "testcases_testcasetag_case_id_338ecd07");

                entity.HasIndex(e => e.TagId, "testcases_testcasetag_tag_id_b16f414a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.TestcasesTestcasetags)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcaseta_case_id_338ecd07_fk_testcases");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TestcasesTestcasetags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testcases_testcasetag_tag_id_b16f414a_fk_management_tag_tag_id");
            });

            modelBuilder.Entity<TestplansHistoricaltestplan>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("testplans_historicaltestplan_pkey");

                entity.ToTable("testplans_historicaltestplan");

                entity.HasIndex(e => e.AuthorId, "testplans_historicaltestplan_author_id_7de6569d");

                entity.HasIndex(e => e.HistoryUserId, "testplans_historicaltestplan_history_user_id_0b43ff14");

                entity.HasIndex(e => e.IsActive, "testplans_historicaltestplan_isactive_110bcb89");

                entity.HasIndex(e => e.Name, "testplans_historicaltestplan_name_d1afc49f");

                entity.HasIndex(e => e.Name, "testplans_historicaltestplan_name_d1afc49f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.ParentId, "testplans_historicaltestplan_parent_id_4d7e6ee8");

                entity.HasIndex(e => e.Id, "testplans_historicaltestplan_plan_id_91d31b13");

                entity.HasIndex(e => e.ProductId, "testplans_historicaltestplan_product_id_2410d78b");

                entity.HasIndex(e => e.ProductVersionId, "testplans_historicaltestplan_product_version_id_4598a8b7");

                entity.HasIndex(e => e.TypeId, "testplans_historicaltestplan_type_id_65c12bbd");

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("create_date");

                entity.Property(e => e.ExtraLink)
                    .HasMaxLength(1024)
                    .HasColumnName("extra_link");

                entity.Property(e => e.HistoryChangeReason).HasColumnName("history_change_reason");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("history_date");

                entity.Property(e => e.HistoryType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("history_type");

                entity.Property(e => e.HistoryUserId).HasColumnName("history_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductVersionId).HasColumnName("product_version_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.HistoryUser)
                    .WithMany(p => p.TestplansHistoricaltestplans)
                    .HasForeignKey(d => d.HistoryUserId)
                    .HasConstraintName("testplans_historical_history_user_id_0b43ff14_fk_auth_user");
            });

            modelBuilder.Entity<TestplansPlantype>(entity =>
            {
                entity.ToTable("testplans_plantype");

                entity.HasIndex(e => e.Name, "testplans_plantype_name_1e9c6899_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "testplans_plantype_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testplans_plantype_type_id_seq'::regclass)");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TestplansTestplan>(entity =>
            {
                entity.ToTable("testplans_testplan");

                entity.HasIndex(e => e.AuthorId, "testplans_testplan_author_id_8fc1910b");

                entity.HasIndex(e => e.IsActive, "testplans_testplan_isactive_4efcc884");

                entity.HasIndex(e => e.Name, "testplans_testplan_name_0bcb1318");

                entity.HasIndex(e => e.Name, "testplans_testplan_name_0bcb1318_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.ParentId, "testplans_testplan_parent_id_c3460a73");

                entity.HasIndex(e => e.ProductId, "testplans_testplan_product_id_6e99180c");

                entity.HasIndex(e => e.ProductVersionId, "testplans_testplan_product_version_id_0ad731f7");

                entity.HasIndex(e => e.TypeId, "testplans_testplan_type_id_b83ae87b");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testplans_testplan_plan_id_seq'::regclass)");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("create_date");

                entity.Property(e => e.ExtraLink)
                    .HasMaxLength(1024)
                    .HasColumnName("extra_link");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductVersionId).HasColumnName("product_version_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TestplansTestplans)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplan_author_id_8fc1910b_fk_auth_user_id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("testplans_testplan_parent_id_c3460a73_fk_testplans_testplan_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TestplansTestplans)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplan_product_id_6e99180c_fk_management_product_id");

                entity.HasOne(d => d.ProductVersion)
                    .WithMany(p => p.TestplansTestplans)
                    .HasForeignKey(d => d.ProductVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplan_product_version_id_0ad731f7_fk_managemen");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TestplansTestplans)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplan_type_id_b83ae87b_fk_testplans");
            });

            modelBuilder.Entity<TestplansTestplanemailsetting>(entity =>
            {
                entity.ToTable("testplans_testplanemailsettings");

                entity.HasIndex(e => e.PlanId, "testplans_testplanemailsettings_plan_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutoToCaseDefaultTester).HasColumnName("auto_to_case_default_tester");

                entity.Property(e => e.AutoToCaseOwner).HasColumnName("auto_to_case_owner");

                entity.Property(e => e.AutoToPlanAuthor).HasColumnName("auto_to_plan_author");

                entity.Property(e => e.NotifyOnCaseUpdate).HasColumnName("notify_on_case_update");

                entity.Property(e => e.NotifyOnPlanUpdate).HasColumnName("notify_on_plan_update");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithOne(p => p.TestplansTestplanemailsetting)
                    .HasForeignKey<TestplansTestplanemailsetting>(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplanem_plan_id_036c434f_fk_testplans");
            });

            modelBuilder.Entity<TestplansTestplantag>(entity =>
            {
                entity.ToTable("testplans_testplantag");

                entity.HasIndex(e => e.PlanId, "testplans_testplantag_plan_id_f5c9e46a");

                entity.HasIndex(e => e.TagId, "testplans_testplantag_tag_id_4a5c61b6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TestplansTestplantags)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplanta_plan_id_f5c9e46a_fk_testplans");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TestplansTestplantags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testplans_testplantag_tag_id_4a5c61b6_fk_management_tag_tag_id");
            });

            modelBuilder.Entity<TestrunsHistoricaltestexecution>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("testruns_historicaltestcaserun_pkey");

                entity.ToTable("testruns_historicaltestexecution");

                entity.HasIndex(e => e.AssigneeId, "testruns_historicaltestcaserun_assignee_id_d29156d3");

                entity.HasIndex(e => e.BuildId, "testruns_historicaltestcaserun_build_id_a1f62a12");

                entity.HasIndex(e => e.CaseId, "testruns_historicaltestcaserun_case_id_4dad63dd");

                entity.HasIndex(e => e.Id, "testruns_historicaltestcaserun_case_run_id_870e6917");

                entity.HasIndex(e => e.StatusId, "testruns_historicaltestcaserun_case_run_status_id_8e094bc0");

                entity.HasIndex(e => e.HistoryUserId, "testruns_historicaltestcaserun_history_user_id_d11b82d1");

                entity.HasIndex(e => e.RunId, "testruns_historicaltestcaserun_run_id_cbe73584");

                entity.HasIndex(e => e.TestedById, "testruns_historicaltestcaserun_tested_by_id_58ab895b");

                entity.HasIndex(e => e.StartDate, "testruns_historicaltestexecution_start_date_3e5ed561");

                entity.HasIndex(e => e.StopDate, "testruns_historicaltestexecution_stop_date_d659f81c");

                entity.Property(e => e.HistoryId)
                    .HasColumnName("history_id")
                    .HasDefaultValueSql("nextval('testruns_historicaltestcaserun_history_id_seq'::regclass)");

                entity.Property(e => e.AssigneeId).HasColumnName("assignee_id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.CaseTextVersion).HasColumnName("case_text_version");

                entity.Property(e => e.HistoryChangeReason).HasColumnName("history_change_reason");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("history_date");

                entity.Property(e => e.HistoryType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("history_type");

                entity.Property(e => e.HistoryUserId).HasColumnName("history_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RunId).HasColumnName("run_id");

                entity.Property(e => e.Sortkey).HasColumnName("sortkey");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StopDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("stop_date");

                entity.Property(e => e.TestedById).HasColumnName("tested_by_id");

                entity.HasOne(d => d.HistoryUser)
                    .WithMany(p => p.TestrunsHistoricaltestexecutions)
                    .HasForeignKey(d => d.HistoryUserId)
                    .HasConstraintName("testruns_historicalt_history_user_id_d11b82d1_fk_auth_user");
            });

            modelBuilder.Entity<TestrunsHistoricaltestrun>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("testruns_historicaltestrun_pkey");

                entity.ToTable("testruns_historicaltestrun");

                entity.HasIndex(e => e.BuildId, "testruns_historicaltestrun_build_id_83cb88d1");

                entity.HasIndex(e => e.DefaultTesterId, "testruns_historicaltestrun_default_tester_id_bfc251b2");

                entity.HasIndex(e => e.HistoryUserId, "testruns_historicaltestrun_history_user_id_8021d038");

                entity.HasIndex(e => e.ManagerId, "testruns_historicaltestrun_manager_id_48e016d3");

                entity.HasIndex(e => e.PlanId, "testruns_historicaltestrun_plan_id_adfcb9d1");

                entity.HasIndex(e => e.PlannedStart, "testruns_historicaltestrun_planned_start_614a868d");

                entity.HasIndex(e => e.PlannedStop, "testruns_historicaltestrun_planned_stop_f3a63beb");

                entity.HasIndex(e => e.ProductVersionId, "testruns_historicaltestrun_product_version_id_d75752c8");

                entity.HasIndex(e => e.Id, "testruns_historicaltestrun_run_id_0ef66b6e");

                entity.HasIndex(e => e.StartDate, "testruns_historicaltestrun_start_date_2966e83c");

                entity.HasIndex(e => e.StopDate, "testruns_historicaltestrun_stop_date_df8f576c");

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.DefaultTesterId).HasColumnName("default_tester_id");

                entity.Property(e => e.HistoryChangeReason).HasColumnName("history_change_reason");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("history_date");

                entity.Property(e => e.HistoryType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("history_type");

                entity.Property(e => e.HistoryUserId).HasColumnName("history_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlannedStart)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("planned_start");

                entity.Property(e => e.PlannedStop)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("planned_stop");

                entity.Property(e => e.ProductVersionId).HasColumnName("product_version_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("start_date");

                entity.Property(e => e.StopDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("stop_date");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnName("summary");

                entity.HasOne(d => d.HistoryUser)
                    .WithMany(p => p.TestrunsHistoricaltestruns)
                    .HasForeignKey(d => d.HistoryUserId)
                    .HasConstraintName("testruns_historicalt_history_user_id_8021d038_fk_auth_user");
            });

            modelBuilder.Entity<TestrunsTestexecution>(entity =>
            {
                entity.ToTable("testruns_testexecution");

                entity.HasIndex(e => e.AssigneeId, "testruns_testcaserun_assignee_id_0953e76e");

                entity.HasIndex(e => e.BuildId, "testruns_testcaserun_build_id_377936c9");

                entity.HasIndex(e => e.CaseId, "testruns_testcaserun_case_id_391a4725");

                entity.HasIndex(e => new { e.CaseId, e.RunId, e.CaseTextVersion }, "testruns_testcaserun_case_id_run_id_case_text_8e2fe8df_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.StatusId, "testruns_testcaserun_case_run_status_id_e34ff8c0");

                entity.HasIndex(e => e.RunId, "testruns_testcaserun_run_id_749e1f8b");

                entity.HasIndex(e => e.TestedById, "testruns_testcaserun_tested_by_id_f03a7efe");

                entity.HasIndex(e => e.StartDate, "testruns_testexecution_start_date_d50373f5");

                entity.HasIndex(e => e.StopDate, "testruns_testexecution_stop_date_1e245a90");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testruns_testcaserun_case_run_id_seq'::regclass)");

                entity.Property(e => e.AssigneeId).HasColumnName("assignee_id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.CaseTextVersion).HasColumnName("case_text_version");

                entity.Property(e => e.RunId).HasColumnName("run_id");

                entity.Property(e => e.Sortkey).HasColumnName("sortkey");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StopDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("stop_date");

                entity.Property(e => e.TestedById).HasColumnName("tested_by_id");

                entity.HasOne(d => d.Assignee)
                    .WithMany(p => p.TestrunsTestexecutionAssignees)
                    .HasForeignKey(d => d.AssigneeId)
                    .HasConstraintName("testruns_testexecution_assignee_id_0daefb61_fk_auth_user_id");

                entity.HasOne(d => d.Build)
                    .WithMany(p => p.TestrunsTestexecutions)
                    .HasForeignKey(d => d.BuildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testcaserun_build_id_377936c9_fk_managemen");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.TestrunsTestexecutions)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testexecuti_case_id_24b74b89_fk_testcases");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.TestrunsTestexecutions)
                    .HasForeignKey(d => d.RunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testexecution_run_id_b07eceea_fk_testruns_testrun_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TestrunsTestexecutions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testexecuti_status_id_82e677b4_fk_testruns_");

                entity.HasOne(d => d.TestedBy)
                    .WithMany(p => p.TestrunsTestexecutionTestedBies)
                    .HasForeignKey(d => d.TestedById)
                    .HasConstraintName("testruns_testexecution_tested_by_id_23ec246c_fk_auth_user_id");
            });

            modelBuilder.Entity<TestrunsTestexecutionstatus>(entity =>
            {
                entity.ToTable("testruns_testexecutionstatus");

                entity.HasIndex(e => e.Name, "testruns_testcaserunstatus_name_5027fe8b_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "testruns_testcaserunstatus_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testruns_testcaserunstatus_case_run_status_id_seq'::regclass)");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("color");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("icon");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<TestrunsTestrun>(entity =>
            {
                entity.ToTable("testruns_testrun");

                entity.HasIndex(e => e.BuildId, "testruns_testrun_build_id_fca012cf");

                entity.HasIndex(e => e.DefaultTesterId, "testruns_testrun_default_tester_id_cfd29db3");

                entity.HasIndex(e => e.ManagerId, "testruns_testrun_manager_id_3b380cf6");

                entity.HasIndex(e => e.PlanId, "testruns_testrun_plan_id_6c5c942a");

                entity.HasIndex(e => e.PlannedStart, "testruns_testrun_planned_start_ea8990da");

                entity.HasIndex(e => e.PlannedStop, "testruns_testrun_planned_stop_db2c9977");

                entity.HasIndex(e => e.ProductVersionId, "testruns_testrun_product_version_id_22b22215");

                entity.HasIndex(e => e.StartDate, "testruns_testrun_start_date_069af648");

                entity.HasIndex(e => e.StopDate, "testruns_testrun_stop_date_ef2271e8");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('testruns_testrun_run_id_seq'::regclass)");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.DefaultTesterId).HasColumnName("default_tester_id");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlannedStart)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("planned_start");

                entity.Property(e => e.PlannedStop)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("planned_stop");

                entity.Property(e => e.ProductVersionId).HasColumnName("product_version_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("start_date");

                entity.Property(e => e.StopDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("stop_date");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnName("summary");

                entity.HasOne(d => d.Build)
                    .WithMany(p => p.TestrunsTestruns)
                    .HasForeignKey(d => d.BuildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testrun_build_id_fca012cf_fk_management_build_build_id");

                entity.HasOne(d => d.DefaultTester)
                    .WithMany(p => p.TestrunsTestrunDefaultTesters)
                    .HasForeignKey(d => d.DefaultTesterId)
                    .HasConstraintName("testruns_testrun_default_tester_id_cfd29db3_fk_auth_user_id");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.TestrunsTestrunManagers)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testrun_manager_id_3b380cf6_fk_auth_user_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TestrunsTestruns)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testrun_plan_id_6c5c942a_fk_testplans_testplan_plan_id");

                entity.HasOne(d => d.ProductVersion)
                    .WithMany(p => p.TestrunsTestruns)
                    .HasForeignKey(d => d.ProductVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testrun_product_version_id_22b22215_fk_managemen");
            });

            modelBuilder.Entity<TestrunsTestruncc>(entity =>
            {
                entity.ToTable("testruns_testruncc");

                entity.HasIndex(e => e.RunId, "testruns_testruncc_run_id_e1329c9b");

                entity.HasIndex(e => new { e.RunId, e.UserId }, "testruns_testruncc_run_id_who_c5339b99_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "testruns_testruncc_who_eac83187");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RunId).HasColumnName("run_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.TestrunsTestrunccs)
                    .HasForeignKey(d => d.RunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testruncc_run_id_e1329c9b_fk_testruns_testrun_run_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TestrunsTestrunccs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testruncc_user_id_d87465d8_fk_auth_user_id");
            });

            modelBuilder.Entity<TestrunsTestruntag>(entity =>
            {
                entity.ToTable("testruns_testruntag");

                entity.HasIndex(e => e.RunId, "testruns_testruntag_run_id_08efd935");

                entity.HasIndex(e => e.TagId, "testruns_testruntag_tag_id_71c717c0");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RunId).HasColumnName("run_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.TestrunsTestruntags)
                    .HasForeignKey(d => d.RunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testruntag_run_id_08efd935_fk_testruns_testrun_run_id");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TestrunsTestruntags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("testruns_testruntag_tag_id_71c717c0_fk_management_tag_tag_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
