﻿// <auto-generated />
using Abp.Authorization;
using Abp.BackgroundJobs;
using Abp.Notifications;
using fruitShop.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace fruitShop.Migrations
{
    [DbContext(typeof(fruitShopDbContext))]
    [Migration("20180313223849_Permissions")]
    partial class Permissions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abp.Application.Editions.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("AbpEditions");
                });

            modelBuilder.Entity("Abp.Application.Features.FeatureSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FeatureSetting");
                });

            modelBuilder.Entity("Abp.Auditing.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrowserInfo");

                    b.Property<string>("ClientIpAddress");

                    b.Property<string>("ClientName");

                    b.Property<string>("CustomData");

                    b.Property<string>("Exception");

                    b.Property<int>("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime");

                    b.Property<int?>("ImpersonatorTenantId");

                    b.Property<long?>("ImpersonatorUserId");

                    b.Property<string>("MethodName");

                    b.Property<string>("Parameters");

                    b.Property<string>("ServiceName");

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AbpAuditLogs");
                });

            modelBuilder.Entity("Abp.Authorization.PermissionSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsGranted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("RoleId");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpRoleClaims");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("EmailAddress");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.Property<long?>("UserLinkId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AbpUserAccounts");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserClaims");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserLogins");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLoginAttempt", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(256);

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreationTime");

                    b.Property<byte>("Result");

                    b.Property<string>("TenancyName")
                        .HasMaxLength(64);

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.Property<string>("UserNameOrEmailAddress")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AbpUserLoginAttempts");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserOrganizationUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("OrganizationUnitId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AbpUserOrganizationUnits");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("RoleId");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserRoles");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserTokens");
                });

            modelBuilder.Entity("Abp.BackgroundJobs.BackgroundJobInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsAbandoned");

                    b.Property<string>("JobArgs")
                        .IsRequired()
                        .HasMaxLength(1048576);

                    b.Property<string>("JobType")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<DateTime?>("LastTryTime");

                    b.Property<DateTime>("NextTryTime");

                    b.Property<byte>("Priority");

                    b.Property<short>("TryCount");

                    b.HasKey("Id");

                    b.ToTable("AbpBackgroundJobs");
                });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.Property<string>("Value")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpSettings");
                });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Icon")
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDisabled");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("AbpLanguages");
                });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguageText", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(67108864);

                    b.HasKey("Id");

                    b.ToTable("AbpLanguageTexts");
                });

            modelBuilder.Entity("Abp.Notifications.NotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Data")
                        .HasMaxLength(1048576);

                    b.Property<string>("DataTypeName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityId")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(250);

                    b.Property<string>("ExcludedUserIds")
                        .HasMaxLength(131072);

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(96);

                    b.Property<byte>("Severity");

                    b.Property<string>("TenantIds")
                        .HasMaxLength(131072);

                    b.Property<string>("UserIds")
                        .HasMaxLength(131072);

                    b.HasKey("Id");

                    b.ToTable("AbpNotifications");
                });

            modelBuilder.Entity("Abp.Notifications.NotificationSubscriptionInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("EntityId")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(250);

                    b.Property<string>("NotificationName")
                        .HasMaxLength(96);

                    b.Property<int?>("TenantId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AbpNotificationSubscriptions");
                });

            modelBuilder.Entity("Abp.Notifications.TenantNotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Data")
                        .HasMaxLength(1048576);

                    b.Property<string>("DataTypeName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityId")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(250);

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(96);

                    b.Property<byte>("Severity");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("AbpTenantNotifications");
                });

            modelBuilder.Entity("Abp.Notifications.UserNotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("State");

                    b.Property<int?>("TenantId");

                    b.Property<Guid>("TenantNotificationId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AbpUserNotifications");
                });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(95);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<long?>("ParentId");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("AbpOrganizationUnits");
                });

            modelBuilder.Entity("fruitShop.Authorization.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("Description")
                        .HasMaxLength(5000);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsStatic");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("LastModifierUserId");

                    b.ToTable("AbpRoles");
                });

            modelBuilder.Entity("fruitShop.Authorization.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AuthenticationSource")
                        .HasMaxLength(64);

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("EmailConfirmationCode")
                        .HasMaxLength(328);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEmailConfirmed");

                    b.Property<bool>("IsLockoutEnabled");

                    b.Property<bool>("IsPhoneNumberConfirmed");

                    b.Property<bool>("IsTwoFactorEnabled");

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<DateTime?>("LockoutEndDateUtc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedEmailAddress")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("PasswordResetCode")
                        .HasMaxLength(328);

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("TenantId");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("AbpUsers");
                });

            modelBuilder.Entity("fruitShop.Domain.fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("colour");

                    b.Property<string>("name");

                    b.Property<decimal>("pricePerItem");

                    b.Property<int>("stockAvailable");

                    b.HasKey("Id");

                    b.ToTable("dFruit");
                });

            modelBuilder.Entity("fruitShop.Domain.staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("dStaff");
                });

            modelBuilder.Entity("fruitShop.Domain.supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contact");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("dSuppliers");
                });

            modelBuilder.Entity("fruitShop.Domain.SupplierFruit", b =>
                {
                    b.Property<int>("supplierId");

                    b.Property<int>("fruitId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<int>("Id");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<decimal>("Price");

                    b.HasKey("supplierId", "fruitId");

                    b.HasIndex("fruitId");

                    b.ToTable("dSupplierFruit");
                });

            modelBuilder.Entity("fruitShop.MultiTenancy.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConnectionString")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("CreatorUserId1");

                    b.Property<long?>("DeleterUserId");

                    b.Property<long?>("DeleterUserId1");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<int?>("EditionId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<long?>("LastModifierUserId1");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("TenancyName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId1");

                    b.HasIndex("DeleterUserId1");

                    b.HasIndex("EditionId");

                    b.HasIndex("LastModifierUserId1");

                    b.ToTable("AbpTenants");
                });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
                {
                    b.HasBaseType("Abp.Application.Features.FeatureSetting");

                    b.Property<int>("EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator().HasValue("EditionFeatureSetting");
                });

            modelBuilder.Entity("Abp.MultiTenancy.TenantFeatureSetting", b =>
                {
                    b.HasBaseType("Abp.Application.Features.FeatureSetting");


                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator().HasValue("TenantFeatureSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
                {
                    b.HasBaseType("Abp.Authorization.PermissionSetting");

                    b.Property<int>("RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator().HasValue("RolePermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
                {
                    b.HasBaseType("Abp.Authorization.PermissionSetting");

                    b.Property<long>("UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator().HasValue("UserPermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
                {
                    b.HasOne("fruitShop.Authorization.Roles.Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User")
                        .WithMany("Settings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
                {
                    b.HasOne("Abp.Organizations.OrganizationUnit", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("fruitShop.Authorization.Roles.Role", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("fruitShop.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("fruitShop.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("fruitShop.Domain.SupplierFruit", b =>
                {
                    b.HasOne("fruitShop.Domain.fruit", "fruit")
                        .WithMany("SupplierFruits")
                        .HasForeignKey("fruitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("fruitShop.Domain.supplier", "supplier")
                        .WithMany("SupplierFruits")
                        .HasForeignKey("supplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("fruitShop.MultiTenancy.Tenant", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId1");

                    b.HasOne("fruitShop.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId1");

                    b.HasOne("Abp.Application.Editions.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId");

                    b.HasOne("fruitShop.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId1");
                });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
                {
                    b.HasOne("Abp.Application.Editions.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
                {
                    b.HasOne("fruitShop.Authorization.Roles.Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
                {
                    b.HasOne("fruitShop.Authorization.Users.User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
