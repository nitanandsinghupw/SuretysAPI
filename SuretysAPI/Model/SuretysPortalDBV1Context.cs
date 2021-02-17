using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class SuretysPortalDBV1Context : DbContext
    {
        public SuretysPortalDBV1Context()
        {
        }

        public SuretysPortalDBV1Context(DbContextOptions<SuretysPortalDBV1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AbpAuditLog> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJob> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpDynamicParameter> AbpDynamicParameters { get; set; }
        public virtual DbSet<AbpDynamicParameterValue> AbpDynamicParameterValues { get; set; }
        public virtual DbSet<AbpEdition> AbpEditions { get; set; }
        public virtual DbSet<AbpEntityChange> AbpEntityChanges { get; set; }
        public virtual DbSet<AbpEntityChangeSet> AbpEntityChangeSets { get; set; }
        public virtual DbSet<AbpEntityDynamicParameter> AbpEntityDynamicParameters { get; set; }
        public virtual DbSet<AbpEntityDynamicParameterValue> AbpEntityDynamicParameterValues { get; set; }
        public virtual DbSet<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; }
        public virtual DbSet<AbpFeature> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguage> AbpLanguages { get; set; }
        public virtual DbSet<AbpLanguageText> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpNotification> AbpNotifications { get; set; }
        public virtual DbSet<AbpNotificationSubscription> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpOrganizationUnit> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; }
        public virtual DbSet<AbpPermission> AbpPermissions { get; set; }
        public virtual DbSet<AbpPersistedGrant> AbpPersistedGrants { get; set; }
        public virtual DbSet<AbpRole> AbpRoles { get; set; }
        public virtual DbSet<AbpRoleClaim> AbpRoleClaims { get; set; }
        public virtual DbSet<AbpSetting> AbpSettings { get; set; }
        public virtual DbSet<AbpTenant> AbpTenants { get; set; }
        public virtual DbSet<AbpTenantNotification> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpUser> AbpUsers { get; set; }
        public virtual DbSet<AbpUserAccount> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserClaim> AbpUserClaims { get; set; }
        public virtual DbSet<AbpUserLogin> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserLoginAttempt> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserNotification> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRole> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUserToken> AbpUserTokens { get; set; }
        public virtual DbSet<AbpWebhookEvent> AbpWebhookEvents { get; set; }
        public virtual DbSet<AbpWebhookSendAttempt> AbpWebhookSendAttempts { get; set; }
        public virtual DbSet<AbpWebhookSubscription> AbpWebhookSubscriptions { get; set; }
        public virtual DbSet<AdditionalProductsMaster> AdditionalProductsMasters { get; set; }
        public virtual DbSet<AdditionalProductsToDealer> AdditionalProductsToDealers { get; set; }
        public virtual DbSet<AdditionalProductsUsed> AdditionalProductsUseds { get; set; }
        public virtual DbSet<AppBinaryObject> AppBinaryObjects { get; set; }
        public virtual DbSet<AppChatMessage> AppChatMessages { get; set; }
        public virtual DbSet<AppFriendship> AppFriendships { get; set; }
        public virtual DbSet<AppInvoice> AppInvoices { get; set; }
        public virtual DbSet<AppSubscriptionPayment> AppSubscriptionPayments { get; set; }
        public virtual DbSet<AppSubscriptionPaymentsExtensionDatum> AppSubscriptionPaymentsExtensionData { get; set; }
        public virtual DbSet<AppUserDelegation> AppUserDelegations { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<CreditType> CreditTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerValidation> CustomerValidations { get; set; }
        public virtual DbSet<DealerGroup> DealerGroups { get; set; }
        public virtual DbSet<DealerShip> DealerShips { get; set; }
        public virtual DbSet<DealerToLender> DealerToLenders { get; set; }
        public virtual DbSet<DeclineReasonMaster> DeclineReasonMasters { get; set; }
        public virtual DbSet<Lender> Lenders { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NoteStatus> NoteStatuses { get; set; }
        public virtual DbSet<NotificationQueue> NotificationQueues { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<PolicyDeclineReason> PolicyDeclineReasons { get; set; }
        public virtual DbSet<StampingFeesInstruction> StampingFeesInstructions { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<SurplusLinesTaxInstruction> SurplusLinesTaxInstructions { get; set; }
        public virtual DbSet<SurplusLinesTaxis> SurplusLinesTaxes { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=tcp:suretysdb.database.windows.net,1433;Database=SuretysPortalDBV1;UID=SuretysDbAdmin;PWD=Suretys@1404;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AbpAuditLog>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ExecutionDuration }, "IX_AbpAuditLogs_TenantId_ExecutionDuration");

                entity.HasIndex(e => new { e.TenantId, e.ExecutionTime }, "IX_AbpAuditLogs_TenantId_ExecutionTime");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpAuditLogs_TenantId_UserId");

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJob>(entity =>
            {
                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime }, "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<AbpDynamicParameter>(entity =>
            {
                entity.HasIndex(e => new { e.ParameterName, e.TenantId }, "IX_AbpDynamicParameters_ParameterName_TenantId")
                    .IsUnique()
                    .HasFilter("([ParameterName] IS NOT NULL AND [TenantId] IS NOT NULL)");
            });

            modelBuilder.Entity<AbpDynamicParameterValue>(entity =>
            {
                entity.HasIndex(e => e.DynamicParameterId, "IX_AbpDynamicParameterValues_DynamicParameterId");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.DynamicParameter)
                    .WithMany(p => p.AbpDynamicParameterValues)
                    .HasForeignKey(d => d.DynamicParameterId);
            });

            modelBuilder.Entity<AbpEdition>(entity =>
            {
                entity.Property(e => e.AnnualPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DailyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MonthlyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.WeeklyPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AbpEntityChange>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeSetId, "IX_AbpEntityChanges_EntityChangeSetId");

                entity.HasIndex(e => new { e.EntityTypeFullName, e.EntityId }, "IX_AbpEntityChanges_EntityTypeFullName_EntityId");

                entity.Property(e => e.EntityId).HasMaxLength(48);

                entity.Property(e => e.EntityTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChangeSet)
                    .WithMany(p => p.AbpEntityChanges)
                    .HasForeignKey(d => d.EntityChangeSetId);
            });

            modelBuilder.Entity<AbpEntityChangeSet>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.CreationTime }, "IX_AbpEntityChangeSets_TenantId_CreationTime");

                entity.HasIndex(e => new { e.TenantId, e.Reason }, "IX_AbpEntityChangeSets_TenantId_Reason");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpEntityChangeSets_TenantId_UserId");

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.Reason).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpEntityDynamicParameter>(entity =>
            {
                entity.HasIndex(e => e.DynamicParameterId, "IX_AbpEntityDynamicParameters_DynamicParameterId");

                entity.HasIndex(e => new { e.EntityFullName, e.DynamicParameterId, e.TenantId }, "IX_AbpEntityDynamicParameters_EntityFullName_DynamicParameterId_TenantId")
                    .IsUnique()
                    .HasFilter("([EntityFullName] IS NOT NULL AND [TenantId] IS NOT NULL)");

                entity.HasOne(d => d.DynamicParameter)
                    .WithMany(p => p.AbpEntityDynamicParameters)
                    .HasForeignKey(d => d.DynamicParameterId);
            });

            modelBuilder.Entity<AbpEntityDynamicParameterValue>(entity =>
            {
                entity.HasIndex(e => e.EntityDynamicParameterId, "IX_AbpEntityDynamicParameterValues_EntityDynamicParameterId");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.EntityDynamicParameter)
                    .WithMany(p => p.AbpEntityDynamicParameterValues)
                    .HasForeignKey(d => d.EntityDynamicParameterId);
            });

            modelBuilder.Entity<AbpEntityPropertyChange>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeId, "IX_AbpEntityPropertyChanges_EntityChangeId");

                entity.Property(e => e.NewValue).HasMaxLength(512);

                entity.Property(e => e.OriginalValue).HasMaxLength(512);

                entity.Property(e => e.PropertyName).HasMaxLength(96);

                entity.Property(e => e.PropertyTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.AbpEntityPropertyChanges)
                    .HasForeignKey(d => d.EntityChangeId);
            });

            modelBuilder.Entity<AbpFeature>(entity =>
            {
                entity.HasIndex(e => new { e.EditionId, e.Name }, "IX_AbpFeatures_EditionId_Name");

                entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpFeatures_TenantId_Name");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpLanguages_TenantId_Name");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.IsDisabled)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<AbpLanguageText>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Source, e.LanguageName, e.Key }, "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AbpNotification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotificationSubscription>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId }, "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId }, "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnit>(entity =>
            {
                entity.HasIndex(e => e.ParentId, "IX_AbpOrganizationUnits_ParentId");

                entity.HasIndex(e => new { e.TenantId, e.Code }, "IX_AbpOrganizationUnits_TenantId_Code")
                    .IsUnique()
                    .HasFilter("([TenantId] IS NOT NULL)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(95);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<AbpOrganizationUnitRole>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId }, "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.RoleId }, "IX_AbpOrganizationUnitRoles_TenantId_RoleId");
            });

            modelBuilder.Entity<AbpPermission>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AbpPermissions_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpPermissions_TenantId_Name");

                entity.HasIndex(e => e.UserId, "IX_AbpPermissions_UserId");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpPersistedGrant>(entity =>
            {
                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_AbpPersistedGrants_SubjectId_ClientId_Type");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AbpRole>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId, "IX_AbpRoles_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId, "IX_AbpRoles_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId, "IX_AbpRoles_LastModifierUserId");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedName }, "IX_AbpRoles_TenantId_NormalizedName");

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.HasAccessToClaim)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.HasAccessToPas)
                    .IsRequired()
                    .HasColumnName("HasAccessToPAS")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.HasAccessToUw)
                    .IsRequired()
                    .HasColumnName("HasAccessToUW")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NormalizedName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRoleCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRoleDeleterUsers)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRoleLastModifierUsers)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AbpRoleClaims_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.ClaimType }, "IX_AbpRoleClaims_TenantId_ClaimType");

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpSetting>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name, e.UserId }, "IX_AbpSettings_TenantId_Name_UserId")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "IX_AbpSettings_UserId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpTenant>(entity =>
            {
                entity.HasIndex(e => e.CreationTime, "IX_AbpTenants_CreationTime");

                entity.HasIndex(e => e.CreatorUserId, "IX_AbpTenants_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId, "IX_AbpTenants_DeleterUserId");

                entity.HasIndex(e => e.EditionId, "IX_AbpTenants_EditionId");

                entity.HasIndex(e => e.LastModifierUserId, "IX_AbpTenants_LastModifierUserId");

                entity.HasIndex(e => e.SubscriptionEndDateUtc, "IX_AbpTenants_SubscriptionEndDateUtc");

                entity.HasIndex(e => e.TenancyName, "IX_AbpTenants_TenancyName");

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.IsInTrialPeriod)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LogoFileType).HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantDeleterUsers)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantLastModifierUsers)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpTenantNotification>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_AbpTenantNotifications_TenantId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpUser>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId, "IX_AbpUsers_CreatorUserId");

                entity.HasIndex(e => e.CustomerId, "IX_AbpUsers_CustomerId");

                entity.HasIndex(e => e.DealerGroupId, "IX_AbpUsers_DealerGroupId");

                entity.HasIndex(e => e.DealerShipId, "IX_AbpUsers_DealerShipId");

                entity.HasIndex(e => e.DeleterUserId, "IX_AbpUsers_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId, "IX_AbpUsers_LastModifierUserId");

                entity.HasIndex(e => e.LenderId, "IX_AbpUsers_LenderId");

                entity.HasIndex(e => e.StateId, "IX_AbpUsers_StateId");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedEmailAddress }, "IX_AbpUsers_TenantId_NormalizedEmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.NormalizedUserName }, "IX_AbpUsers_TenantId_NormalizedUserName");

                entity.HasIndex(e => e.UserTypeId, "IX_AbpUsers_UserTypeId");

                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.BenchmarkTest)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.Edelivery)
                    .IsRequired()
                    .HasColumnName("EDelivery")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.EdeliveryPreference).HasColumnName("EDeliveryPreference");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);

                entity.Property(e => e.IsLivedinAddress6Months)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsUnderwritingUser)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.NormalizedEmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.SecurityStamp).HasMaxLength(128);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AbpUsers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.DealerGroup)
                    .WithMany(p => p.AbpUsers)
                    .HasForeignKey(d => d.DealerGroupId);

                entity.HasOne(d => d.DealerShip)
                    .WithMany(p => p.AbpUsers)
                    .HasForeignKey(d => d.DealerShipId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.AbpUsers)
                    .HasForeignKey(d => d.LenderId);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.AbpUsers)
                    .HasForeignKey(d => d.StateId);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.AbpUsers)
                    .HasForeignKey(d => d.UserTypeId);
            });

            modelBuilder.Entity<AbpUserAccount>(entity =>
            {
                entity.HasIndex(e => e.EmailAddress, "IX_AbpUserAccounts_EmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.EmailAddress }, "IX_AbpUserAccounts_TenantId_EmailAddress");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserAccounts_TenantId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.UserName }, "IX_AbpUserAccounts_TenantId_UserName");

                entity.HasIndex(e => e.UserName, "IX_AbpUserAccounts_UserName");

                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserClaim>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ClaimType }, "IX_AbpUserClaims_TenantId_ClaimType");

                entity.HasIndex(e => e.UserId, "IX_AbpUserClaims_UserId");

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLogin>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.LoginProvider, e.ProviderKey }, "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserLogins_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserLogins_UserId");

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLoginAttempt>(entity =>
            {
                entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result }, "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

                entity.HasIndex(e => new { e.UserId, e.TenantId }, "IX_AbpUserLoginAttempts_UserId_TenantId");

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserNotification>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime }, "IX_AbpUserNotifications_UserId_State_CreationTime");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpUserOrganizationUnit>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId }, "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserOrganizationUnits_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserOrganizationUnits_UserId");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserOrganizationUnits)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserRole>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.RoleId }, "IX_AbpUserRoles_TenantId_RoleId");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserRoles_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserRoles_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserToken>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpUserTokens_TenantId_UserId");

                entity.HasIndex(e => e.UserId, "IX_AbpUserTokens_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpWebhookEvent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.WebhookName).IsRequired();
            });

            modelBuilder.Entity<AbpWebhookSendAttempt>(entity =>
            {
                entity.HasIndex(e => e.WebhookEventId, "IX_AbpWebhookSendAttempts_WebhookEventId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.WebhookEvent)
                    .WithMany(p => p.AbpWebhookSendAttempts)
                    .HasForeignKey(d => d.WebhookEventId);
            });

            modelBuilder.Entity<AbpWebhookSubscription>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Secret).IsRequired();

                entity.Property(e => e.WebhookUri).IsRequired();
            });

            modelBuilder.Entity<AdditionalProductsMaster>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CostRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).IsRequired();
            });

            modelBuilder.Entity<AdditionalProductsToDealer>(entity =>
            {
                entity.HasIndex(e => e.AdditionalProductsMasterId, "IX_AdditionalProductsToDealers_AdditionalProductsMasterId");

                entity.HasIndex(e => e.DealerShipId, "IX_AdditionalProductsToDealers_DealerShipId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AdditionalProductsMaster)
                    .WithMany(p => p.AdditionalProductsToDealers)
                    .HasForeignKey(d => d.AdditionalProductsMasterId);

                entity.HasOne(d => d.DealerShip)
                    .WithMany(p => p.AdditionalProductsToDealers)
                    .HasForeignKey(d => d.DealerShipId);
            });

            modelBuilder.Entity<AdditionalProductsUsed>(entity =>
            {
                entity.HasIndex(e => e.AdditionalProductsMasterId, "IX_AdditionalProductsUseds_AdditionalProductsMasterId");

                entity.HasIndex(e => e.CreditId, "IX_AdditionalProductsUseds_CreditId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdditionalProductCost).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AdditionalProductsMaster)
                    .WithMany(p => p.AdditionalProductsUseds)
                    .HasForeignKey(d => d.AdditionalProductsMasterId);
            });

            modelBuilder.Entity<AppBinaryObject>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_AppBinaryObjects_TenantId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bytes).IsRequired();
            });

            modelBuilder.Entity<AppChatMessage>(entity =>
            {
                entity.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState }, "IX_AppChatMessages_TargetTenantId_TargetUserId_ReadState");

                entity.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState }, "IX_AppChatMessages_TargetTenantId_UserId_ReadState");

                entity.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState }, "IX_AppChatMessages_TenantId_TargetUserId_ReadState");

                entity.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState }, "IX_AppChatMessages_TenantId_UserId_ReadState");

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<AppFriendship>(entity =>
            {
                entity.HasIndex(e => new { e.FriendTenantId, e.FriendUserId }, "IX_AppFriendships_FriendTenantId_FriendUserId");

                entity.HasIndex(e => new { e.FriendTenantId, e.UserId }, "IX_AppFriendships_FriendTenantId_UserId");

                entity.HasIndex(e => new { e.TenantId, e.FriendUserId }, "IX_AppFriendships_TenantId_FriendUserId");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AppFriendships_TenantId_UserId");

                entity.Property(e => e.FriendUserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AppSubscriptionPayment>(entity =>
            {
                entity.HasIndex(e => e.EditionId, "IX_AppSubscriptionPayments_EditionId");

                entity.HasIndex(e => new { e.ExternalPaymentId, e.Gateway }, "IX_AppSubscriptionPayments_ExternalPaymentId_Gateway");

                entity.HasIndex(e => new { e.Status, e.CreationTime }, "IX_AppSubscriptionPayments_Status_CreationTime");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsRecurring)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AppSubscriptionPayments)
                    .HasForeignKey(d => d.EditionId);
            });

            modelBuilder.Entity<AppSubscriptionPaymentsExtensionDatum>(entity =>
            {
                entity.HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted }, "IX_AppSubscriptionPaymentsExtensionData_SubscriptionPaymentId_Key_IsDeleted")
                    .IsUnique()
                    .HasFilter("([Key] IS NOT NULL)");
            });

            modelBuilder.Entity<AppUserDelegation>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.SourceUserId }, "IX_AppUserDelegations_TenantId_SourceUserId");

                entity.HasIndex(e => new { e.TenantId, e.TargetUserId }, "IX_AppUserDelegations_TenantId_TargetUserId");
            });

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.HasIndex(e => e.CreditTypeId, "IX_Credits_CreditTypeId");

                entity.HasIndex(e => e.LenderId, "IX_Credits_LenderId");

                entity.HasIndex(e => e.VehicleId, "IX_Credits_VehicleId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddlProductsCosts).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AddlProductsUsed)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.AddlRebatableCosts).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AmountLeased).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DownPayment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InterestFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InterestRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ltv)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("LTV");

                entity.Property(e => e.MoneyFactor).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MonthalyPayment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MonthlyInterest).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Msrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MSRP");

                entity.Property(e => e.NetCap).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RebatableFees).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ResidualPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ResidualValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RetailValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalFinanced).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalLeaseAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CreditType)
                    .WithMany(p => p.Credits)
                    .HasForeignKey(d => d.CreditTypeId);

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.Credits)
                    .HasForeignKey(d => d.LenderId);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Credits)
                    .HasForeignKey(d => d.VehicleId);
            });

            modelBuilder.Entity<CreditType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.CreditId, "IX_Customers_CreditId");

                entity.HasIndex(e => e.DriverStateId, "IX_Customers_DriverStateId");

                entity.HasIndex(e => e.StateId, "IX_Customers_StateId");

                entity.HasIndex(e => e.UserId, "IX_Customers_UserId");

                entity.HasIndex(e => e.VehicleId, "IX_Customers_VehicleId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BenchmarkTest)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ContactMethod).IsRequired();

                entity.Property(e => e.CustomerHasBankDetails)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();

                entity.HasOne(d => d.DriverState)
                    .WithMany(p => p.CustomerDriverStates)
                    .HasForeignKey(d => d.DriverStateId);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CustomerStates)
                    .HasForeignKey(d => d.StateId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.VehicleId);
            });

            modelBuilder.Entity<CustomerValidation>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_CustomerValidations_CustomerId");

                entity.HasIndex(e => e.UserId, "IX_CustomerValidations_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DateAddressMatchSsn).HasColumnName("DateAddressMatchSSN");

                entity.Property(e => e.DateCrsrun)
                    .HasColumnName("DateCRSRun")
                    .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DateNameMatchSsn).HasColumnName("DateNameMatchSSN");

                entity.Property(e => e.DateSsnvalidated).HasColumnName("DateSSNValidated");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsAddressMatchSsn).HasColumnName("IsAddressMatchSSN");

                entity.Property(e => e.IsCrscalled)
                    .IsRequired()
                    .HasColumnName("IsCRSCalled")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsItin)
                    .IsRequired()
                    .HasColumnName("IsITIN")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsNameMatchSsn).HasColumnName("IsNameMatchSSN");

                entity.Property(e => e.IsOverride)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsSsnvalidated)
                    .IsRequired()
                    .HasColumnName("IsSSNValidated")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerValidations)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerValidations)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<DealerGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address1).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DealerShip>(entity =>
            {
                entity.HasIndex(e => e.DealerGroupId, "IX_DealerShips_DealerGroupId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.DealerGroup)
                    .WithMany(p => p.DealerShips)
                    .HasForeignKey(d => d.DealerGroupId);
            });

            modelBuilder.Entity<DealerToLender>(entity =>
            {
                entity.HasIndex(e => e.DealerShipId, "IX_DealerToLenders_DealerShipId");

                entity.HasIndex(e => e.LenderId, "IX_DealerToLenders_LenderId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DealerShip)
                    .WithMany(p => p.DealerToLenders)
                    .HasForeignKey(d => d.DealerShipId);

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.DealerToLenders)
                    .HasForeignKey(d => d.LenderId);
            });

            modelBuilder.Entity<DeclineReasonMaster>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lender>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InterestRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.MoneyFactor).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasIndex(e => e.DealerGroupId, "IX_Notes_DealerGroupId");

                entity.HasIndex(e => e.DealerShipId, "IX_Notes_DealerShipId");

                entity.HasIndex(e => e.LenderId, "IX_Notes_LenderId");

                entity.HasIndex(e => e.NoteStatusId, "IX_Notes_NoteStatusId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DealerGroup)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.DealerGroupId);

                entity.HasOne(d => d.DealerShip)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.DealerShipId);

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.LenderId);

                entity.HasOne(d => d.NoteStatus)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.NoteStatusId);
            });

            modelBuilder.Entity<NoteStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<NotificationQueue>(entity =>
            {
                entity.ToTable("NotificationQueue");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.HasIndex(e => e.ApproverUserId, "IX_Policies_ApproverUserId");

                entity.HasIndex(e => e.CreditId, "IX_Policies_CreditId");

                entity.HasIndex(e => e.CustomerId, "IX_Policies_CustomerId");

                entity.HasIndex(e => e.DealerGroupId, "IX_Policies_DealerGroupId");

                entity.HasIndex(e => e.DealerShipId, "IX_Policies_DealerShipId");

                entity.HasIndex(e => e.LenderId, "IX_Policies_LenderId");

                entity.HasIndex(e => e.UserId, "IX_Policies_UserId");

                entity.HasIndex(e => e.VehicleId, "IX_Policies_VehicleId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateUnderwritingRun).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DeclineQualifyMonthly).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Esignature).HasColumnName("ESignature");

                entity.Property(e => e.FurtherReview)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsEdit)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsItin)
                    .IsRequired()
                    .HasColumnName("IsITIN")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsManualReview)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ManualActionTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.ManualEndTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.ManualStartTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.ManualUwstatus).HasColumnName("ManualUWStatus");

                entity.Property(e => e.MonthalyPremium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PolicyStep).HasColumnName("policyStep");

                entity.Property(e => e.ReadDocs)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.SleightFormUrl).HasColumnName("SLEightFormUrl");

                entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ApproverUser)
                    .WithMany(p => p.PolicyApproverUsers)
                    .HasForeignKey(d => d.ApproverUserId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.DealerGroup)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.DealerGroupId);

                entity.HasOne(d => d.DealerShip)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.DealerShipId);

                entity.HasOne(d => d.Lender)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.LenderId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PolicyUsers)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.VehicleId);
            });

            modelBuilder.Entity<PolicyDeclineReason>(entity =>
            {
                entity.HasIndex(e => e.PolicyId, "IX_PolicyDeclineReasons_PolicyId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyDeclineReasons)
                    .HasForeignKey(d => d.PolicyId);
            });

            modelBuilder.Entity<StampingFeesInstruction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CreationTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SurplusLinesTaxInstruction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SurplusLinesTaxis>(entity =>
            {
                entity.HasIndex(e => e.StampingFeesInstructionId, "IX_SurplusLinesTaxes_StampingFeesInstructionId");

                entity.HasIndex(e => e.StateId, "IX_SurplusLinesTaxes_StateId");

                entity.HasIndex(e => e.SurplusLinesTaxInstructionId, "IX_SurplusLinesTaxes_SurplusLinesTaxInstructionId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsArchive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.StampingFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StampingFeeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).IsRequired();

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.StampingFeesInstruction)
                    .WithMany(p => p.SurplusLinesTaxes)
                    .HasForeignKey(d => d.StampingFeesInstructionId);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SurplusLinesTaxes)
                    .HasForeignKey(d => d.StateId);

                entity.HasOne(d => d.SurplusLinesTaxInstruction)
                    .WithMany(p => p.SurplusLinesTaxes)
                    .HasForeignKey(d => d.SurplusLinesTaxInstructionId);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Vehicles_CustomerId");

                entity.HasIndex(e => e.DealerShipId, "IX_Vehicles_DealerShipId");

                entity.HasIndex(e => e.UserId, "IX_Vehicles_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BenchmarkTest)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Make).IsRequired();

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.Vin).HasColumnName("VIN");

                entity.Property(e => e.Year).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.DealerShip)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.DealerShipId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
