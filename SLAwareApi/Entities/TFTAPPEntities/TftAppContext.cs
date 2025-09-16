using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class TftAppContext : DbContext
{
    public TftAppContext()
    {
    }

    public TftAppContext(DbContextOptions<TftAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdditionalCompanyRole> AdditionalCompanyRoles { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<ApplicationHasModule> ApplicationHasModules { get; set; }

    public virtual DbSet<ApplicationPermission> ApplicationPermissions { get; set; }

    public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; }

    public virtual DbSet<ApplicationRolesHasPermission> ApplicationRolesHasPermissions { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<BearerToken> BearerTokens { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<BlogComment> BlogComments { get; set; }

    public virtual DbSet<CampaignTypeQuery> CampaignTypeQueries { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyAppRoleHierarchy> CompanyAppRoleHierarchies { get; set; }

    public virtual DbSet<CompanyApplication> CompanyApplications { get; set; }

    public virtual DbSet<CompanyApplicationModule> CompanyApplicationModules { get; set; }

    public virtual DbSet<CompanyApplicationUser> CompanyApplicationUsers { get; set; }

    public virtual DbSet<CompanyApplicationUserRole> CompanyApplicationUserRoles { get; set; }

    public virtual DbSet<CompanyAuditLog> CompanyAuditLogs { get; set; }

    public virtual DbSet<CompanyConfiguration> CompanyConfigurations { get; set; }

    public virtual DbSet<CompanyIntegration> CompanyIntegrations { get; set; }

    public virtual DbSet<CompanyIntegrationBackup20241121> CompanyIntegrationBackup20241121s { get; set; }

    public virtual DbSet<CompanySettingsOld> CompanySettingsOlds { get; set; }

    public virtual DbSet<CompanyType> CompanyTypes { get; set; }

    public virtual DbSet<CompanyUserDocumentTypeS3Object> CompanyUserDocumentTypeS3Objects { get; set; }

    public virtual DbSet<ConfigurationType> ConfigurationTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryBase> CountryBases { get; set; }

    public virtual DbSet<CountryContinent> CountryContinents { get; set; }

    public virtual DbSet<CountryCurrency> CountryCurrencies { get; set; }

    public virtual DbSet<CountryDiallingCode> CountryDiallingCodes { get; set; }

    public virtual DbSet<CountryLanguage> CountryLanguages { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EmailTracking> EmailTrackings { get; set; }

    public virtual DbSet<EmailType> EmailTypes { get; set; }

    public virtual DbSet<EnquiryType> EnquiryTypes { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<FormCapture> FormCaptures { get; set; }

    public virtual DbSet<FormCapturesNote> FormCapturesNotes { get; set; }

    public virtual DbSet<FormType> FormTypes { get; set; }

    public virtual DbSet<GlobalSetting> GlobalSettings { get; set; }

    public virtual DbSet<IataAirlineCodesCountry> IataAirlineCodesCountries { get; set; }

    public virtual DbSet<Integration> Integrations { get; set; }

    public virtual DbSet<IntegrationAuditlog> IntegrationAuditlogs { get; set; }

    public virtual DbSet<IntegrationAuditlogJob> IntegrationAuditlogJobs { get; set; }

    public virtual DbSet<IntegrationType> IntegrationTypes { get; set; }

    public virtual DbSet<IpAddressWhitelist> IpAddressWhitelists { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<OrganisationType> OrganisationTypes { get; set; }

    public virtual DbSet<PackageType> PackageTypes { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleHasPermission> RoleHasPermissions { get; set; }

    public virtual DbSet<RouteExclusion> RouteExclusions { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SiteApplication> SiteApplications { get; set; }

    public virtual DbSet<SiteApplicationUserSite> SiteApplicationUserSites { get; set; }

    public virtual DbSet<SiteApplicationUserSiteApplicationRole> SiteApplicationUserSiteApplicationRoles { get; set; }

    public virtual DbSet<SiteApplicationUserSiteApplicationRolesPermission> SiteApplicationUserSiteApplicationRolesPermissions { get; set; }

    public virtual DbSet<SiteAsset> SiteAssets { get; set; }

    public virtual DbSet<SiteSmsCredit> SiteSmsCredits { get; set; }

    public virtual DbSet<SiteTravelGroup> SiteTravelGroups { get; set; }

    public virtual DbSet<SiteType> SiteTypes { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<SmsBatch> SmsBatches { get; set; }

    public virtual DbSet<SmsBatchDetail> SmsBatchDetails { get; set; }

    public virtual DbSet<SmsCampaign> SmsCampaigns { get; set; }

    public virtual DbSet<SmsCampaignType> SmsCampaignTypes { get; set; }

    public virtual DbSet<SmsCreditTier> SmsCreditTiers { get; set; }

    public virtual DbSet<SmsFailureDetail> SmsFailureDetails { get; set; }

    public virtual DbSet<SmsRecurrenceType> SmsRecurrenceTypes { get; set; }

    public virtual DbSet<SmsReservedCredit> SmsReservedCredits { get; set; }

    public virtual DbSet<SmsStatus> SmsStatuses { get; set; }

    public virtual DbSet<SmsType> SmsTypes { get; set; }

    public virtual DbSet<SqlQuery> SqlQueries { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<SubFormType> SubFormTypes { get; set; }

    public virtual DbSet<Subregion> Subregions { get; set; }

    public virtual DbSet<Traffic> Traffics { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAccessToken> UserAccessTokens { get; set; }

    public virtual DbSet<UserApplicationRolePermission> UserApplicationRolePermissions { get; set; }

    public virtual DbSet<UserCompany> UserCompanies { get; set; }

    public virtual DbSet<UserHasRole> UserHasRoles { get; set; }

    public virtual DbSet<UserPasswordResetToken> UserPasswordResetTokens { get; set; }

    public virtual DbSet<UserReportingLine> UserReportingLines { get; set; }

    public virtual DbSet<UserRolePermission> UserRolePermissions { get; set; }

    public virtual DbSet<UserSite> UserSites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=41.76.213.213\\\\\\\\TFTDEV01,1435;Initial Catalog=TFT_App;User ID=sa;Password=TailorF!tSA!;Encrypt=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdditionalCompanyRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__addition__3213E83F4E530929");

            entity.ToTable("additional_company_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.AdditionalCompanyRoles)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_role_additional_id_foreign");
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__applicat__3213E83F700BC1F5");

            entity.ToTable("applications");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationImageUrl)
                .HasMaxLength(1000)
                .HasColumnName("application_image_url");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ApplicationHasModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__applicat__3213E83F8E7258FF");

            entity.ToTable("application_has_modules");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Application).WithMany(p => p.ApplicationHasModules)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("application_has_modules_application_id_foreign");

            entity.HasOne(d => d.Module).WithMany(p => p.ApplicationHasModules)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("application_has_modules_module_id_foreign");
        });

        modelBuilder.Entity<ApplicationPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pplication_permissions__3213E83F6404609F");

            entity.ToTable("application_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ApplicationRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__applicat__3213E83F8C9FF1E9");

            entity.ToTable("application_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ApplicationRolesHasPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__application_roles_has_permissions__3213E83F8C9FF1E9");

            entity.ToTable("application_roles_has_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationPermissionsId).HasColumnName("application_permissions_id");
            entity.Property(e => e.ApplicationRoleId).HasColumnName("application_role_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__asset_ty__3213E83FE2BDDA4C");

            entity.ToTable("asset_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<BearerToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bearer_t__3213E83F6CEC158D");

            entity.ToTable("bearer_tokens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyConfigurationId).HasColumnName("company_configuration_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CompanyConfiguration).WithMany(p => p.BearerTokens)
                .HasForeignKey(d => d.CompanyConfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ompany_configuration_id_token_foreign");
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__blogs__3213E83F427948D6");

            entity.ToTable("blogs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.BlogContent)
                .IsUnicode(false)
                .HasColumnName("blog_content");
            entity.Property(e => e.BlogImage)
                .HasMaxLength(255)
                .HasColumnName("blog_image");
            entity.Property(e => e.BlogSource)
                .HasMaxLength(255)
                .HasColumnName("blog_source");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.IsPublished)
                .HasDefaultValue(false)
                .HasColumnName("is_published");
            entity.Property(e => e.PublishedByUserId).HasColumnName("published_by_user_id");
            entity.Property(e => e.PublishedDate)
                .HasMaxLength(255)
                .HasColumnName("published_date");
            entity.Property(e => e.SubTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("sub_title");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_id_foreign");

            entity.HasOne(d => d.PublishedByUser).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.PublishedByUserId)
                .HasConstraintName("published_by_user_id_foreign");
        });

        modelBuilder.Entity<BlogComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__blogs_comment__3213E83F93D16651");

            entity.ToTable("blog_comments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlogComment1)
                .IsUnicode(false)
                .HasColumnName("blog_comment");
            entity.Property(e => e.BlogId).HasColumnName("blog_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<CampaignTypeQuery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__campaign__3213E83FFDCE4508");

            entity.ToTable("campaign_type_queries");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CampaignTypeId).HasColumnName("campaign_type_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.QueryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("query_name");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CampaignType).WithMany(p => p.CampaignTypeQueries)
                .HasForeignKey(d => d.CampaignTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_campaign_type_queries_campaign_type");

            entity.HasOne(d => d.Site).WithMany(p => p.CampaignTypeQueries)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_campaign_type_queries_site");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cities__3213E83FFA47E03F");

            entity.ToTable("cities", "location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.Flag)
                .HasDefaultValue(true)
                .HasColumnName("flag");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(10, 8)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(11, 8)")
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.StateCode)
                .HasMaxLength(255)
                .HasColumnName("state_code");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("state_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");

            entity.HasOne(d => d.Country).WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cities_countries");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cities_states");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__companie__3213E83FDBF4A5EA");

            entity.ToTable("companies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.CompanyTypeId).HasColumnName("company_type_id");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Gds)
                .HasMaxLength(100)
                .HasColumnName("gds");
            entity.Property(e => e.IataNo)
                .HasMaxLength(20)
                .HasColumnName("iata_no");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsVatRegistered)
                .HasDefaultValue(false)
                .HasColumnName("is_vat_registered");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .HasColumnName("logo");
            entity.Property(e => e.OrganisationTypeId).HasColumnName("organisation_type_id");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0)
                .HasColumnName("parent_id");
            entity.Property(e => e.Pcc)
                .HasMaxLength(100)
                .HasColumnName("pcc");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(30)
                .HasColumnName("phone_no");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.Province)
                .HasMaxLength(100)
                .HasColumnName("province");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(100)
                .HasColumnName("registration_number");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(255)
                .HasColumnName("street_address");
            entity.Property(e => e.TradingName)
                .HasMaxLength(255)
                .HasColumnName("trading_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.VatNo)
                .HasMaxLength(20)
                .HasColumnName("vat_no");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .HasColumnName("website");

            entity.HasOne(d => d.CompanyType).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("company_type_id_foreign");

            entity.HasOne(d => d.OrganisationType).WithMany(p => p.Companies)
                .HasForeignKey(d => d.OrganisationTypeId)
                .HasConstraintName("[organisation_type_id_foreign");
        });

        modelBuilder.Entity<CompanyAppRoleHierarchy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83F555E5519");

            entity.ToTable("company_app_role_hierarchy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppRoleId).HasColumnName("app_role_id");
            entity.Property(e => e.AppRoleParentId).HasColumnName("app_role_parent_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.AppRole).WithMany(p => p.CompanyAppRoleHierarchyAppRoles)
                .HasForeignKey(d => d.AppRoleId)
                .HasConstraintName("company_app_role_hierarchy_app_role_id_foreign");

            entity.HasOne(d => d.AppRoleParent).WithMany(p => p.CompanyAppRoleHierarchyAppRoleParents)
                .HasForeignKey(d => d.AppRoleParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("company_app_role_hierarchy_app_role_parent_id_foreign");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyAppRoleHierarchies)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_app_role_hierarchy_company_id_foreign");
        });

        modelBuilder.Entity<CompanyApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FC5AF026C");

            entity.ToTable("company_application");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Application).WithMany(p => p.CompanyApplications)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("company_has_applications_application_id_foreign");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyApplications)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_has_applications_company_id_foreign");
        });

        modelBuilder.Entity<CompanyApplicationModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83F8537686C");

            entity.ToTable("company_application_module");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyApplicationId).HasColumnName("company_application_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CompanyApplication).WithMany(p => p.CompanyApplicationModules)
                .HasForeignKey(d => d.CompanyApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("company_application_module_company_application_id_foreign");

            entity.HasOne(d => d.Module).WithMany(p => p.CompanyApplicationModules)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("company_application_modules_module_id_foreign");
        });

        modelBuilder.Entity<CompanyApplicationUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FB8DCAE0B");

            entity.ToTable("company_application_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyApplicationId).HasColumnName("company_application_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.CompanyApplication).WithMany(p => p.CompanyApplicationUsers)
                .HasForeignKey(d => d.CompanyApplicationId)
                .HasConstraintName("user_application_company_user_id_foreign");

            entity.HasOne(d => d.User).WithMany(p => p.CompanyApplicationUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_application_user_id_foreign");
        });

        modelBuilder.Entity<CompanyApplicationUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83F9DBF0933");

            entity.ToTable("company_application_user_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationRoleId).HasColumnName("application_role_id");
            entity.Property(e => e.CompanyApplicationUserId).HasColumnName("company_application_user_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.ApplicationRole).WithMany(p => p.CompanyApplicationUserRoles)
                .HasForeignKey(d => d.ApplicationRoleId)
                .HasConstraintName("application_user_roles_role_id_foreign");

            entity.HasOne(d => d.CompanyApplicationUser).WithMany(p => p.CompanyApplicationUserRoles)
                .HasForeignKey(d => d.CompanyApplicationUserId)
                .HasConstraintName("company_application_user_id_foreign");
        });

        modelBuilder.Entity<CompanyAuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FFCDC0326");

            entity.ToTable("company_audit_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CompanyTypeId).HasColumnName("company_type_id");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsVatRegistered)
                .HasDefaultValue(false)
                .HasColumnName("is_vat_registered");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .HasColumnName("logo");
            entity.Property(e => e.OrganisationTypeId).HasColumnName("organisation_type_id");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0)
                .HasColumnName("parent_id");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(30)
                .HasColumnName("phone_no");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.Province)
                .HasMaxLength(100)
                .HasColumnName("province");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(100)
                .HasColumnName("registration_number");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(255)
                .HasColumnName("street_address");
            entity.Property(e => e.TradingName)
                .HasMaxLength(255)
                .HasColumnName("trading_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.VatNo)
                .HasMaxLength(20)
                .HasColumnName("vat_no");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .HasColumnName("website");
        });

        modelBuilder.Entity<CompanyConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FD46DA674");

            entity.ToTable("company_configuration");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Configuration).HasColumnName("configuration");
            entity.Property(e => e.ConfigurationTypeId).HasColumnName("configuration_type_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyConfigurations)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_configuration_company_id_foreign");

            entity.HasOne(d => d.ConfigurationType).WithMany(p => p.CompanyConfigurations)
                .HasForeignKey(d => d.ConfigurationTypeId)
                .HasConstraintName("company_configuration_configuration_id_foreign");
        });

        modelBuilder.Entity<CompanyIntegration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FA6FCC040");

            entity.ToTable("company_integration");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IntegrationId).HasColumnName("integration_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(false)
                .HasColumnName("is_active");
            entity.Property(e => e.SettingsPayload).HasColumnName("settings_payload");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyIntegrations)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_integration_company_id_foreign");

            entity.HasOne(d => d.Integration).WithMany(p => p.CompanyIntegrations)
                .HasForeignKey(d => d.IntegrationId)
                .HasConstraintName("company_integration_id_foreign");
        });

        modelBuilder.Entity<CompanyIntegrationBackup20241121>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("company_integration_backup_20241121");

            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IntegrationId).HasColumnName("integration_id");
            entity.Property(e => e.SettingsPayload).HasColumnName("settings_payload");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<CompanySettingsOld>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83F7132E7B8");

            entity.ToTable("company_settings_old");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.S3Configuration).HasColumnName("s3_configuration");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<CompanyType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FB01902E4");

            entity.ToTable("company_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<CompanyUserDocumentTypeS3Object>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83FCAECF1A5");

            entity.ToTable("company_user_document_type_s3_objects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.S3Key)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("s3_key");
            entity.Property(e => e.S3ObjectUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("s3_object_url");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyUserDocumentTypeS3Objects)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("fk_company_id");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.CompanyUserDocumentTypeS3Objects)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("fk_document_type_id");

            entity.HasOne(d => d.User).WithMany(p => p.CompanyUserDocumentTypeS3Objects)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_user_id");
        });

        modelBuilder.Entity<ConfigurationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__configur__3213E83F3401A37E");

            entity.ToTable("configuration_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfigurationModel).HasColumnName("configuration_model");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__countrie__3213E83F88335491");

            entity.ToTable("countries", "location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capital)
                .HasMaxLength(255)
                .HasColumnName("capital");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("currency");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(255)
                .HasColumnName("currency_name");
            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(255)
                .HasColumnName("currency_symbol");
            entity.Property(e => e.Emoji)
                .HasMaxLength(191)
                .HasColumnName("emoji");
            entity.Property(e => e.EmojiU)
                .HasMaxLength(191)
                .HasColumnName("emojiU");
            entity.Property(e => e.Flag)
                .HasDefaultValue(true)
                .HasColumnName("flag");
            entity.Property(e => e.Iso2)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("iso2");
            entity.Property(e => e.Iso3)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("iso3");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(10, 8)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(11, 8)")
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Nationality)
                .HasMaxLength(255)
                .HasColumnName("nationality");
            entity.Property(e => e.Native)
                .HasMaxLength(255)
                .HasColumnName("native");
            entity.Property(e => e.NumericCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("numeric_code");
            entity.Property(e => e.Phonecode)
                .HasMaxLength(255)
                .HasColumnName("phonecode");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .HasColumnName("region");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.Subregion)
                .HasMaxLength(255)
                .HasColumnName("subregion");
            entity.Property(e => e.SubregionId).HasColumnName("subregion_id");
            entity.Property(e => e.Timezones).HasColumnName("timezones");
            entity.Property(e => e.Tld)
                .HasMaxLength(255)
                .HasColumnName("tld");
            entity.Property(e => e.Translations).HasColumnName("translations");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");
        });

        modelBuilder.Entity<CountryBase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__country___3213E83F57D9A469");

            entity.ToTable("country_base");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alpha2Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alpha_2_code");
            entity.Property(e => e.Alpha3Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alpha_3_code");
            entity.Property(e => e.CountryContinentId).HasColumnName("country_continent_id");
            entity.Property(e => e.CountryNameCommon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country_name_common");
            entity.Property(e => e.CountryNameOfficial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country_name_official");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.FlagAlt)
                .HasMaxLength(4000)
                .HasColumnName("flag_alt");
            entity.Property(e => e.FlagPng)
                .HasMaxLength(4000)
                .HasColumnName("flag_png");
            entity.Property(e => e.FlagSvg)
                .HasMaxLength(4000)
                .HasColumnName("flag_svg");
            entity.Property(e => e.GoogleMapsUrl)
                .HasMaxLength(4000)
                .HasColumnName("google_maps_url");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("longitude");
            entity.Property(e => e.OpenstreetMapsUrl)
                .HasMaxLength(4000)
                .HasColumnName("openstreet_maps_url");
            entity.Property(e => e.Timezone)
                .HasMaxLength(100)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CountryContinent).WithMany(p => p.CountryBases)
                .HasForeignKey(d => d.CountryContinentId)
                .HasConstraintName("country_base_continents_id_foreign");
        });

        modelBuilder.Entity<CountryContinent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Continent");

            entity.ToTable("country_continents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContinentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("continent_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<CountryCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__country___3213E83F8924301B");

            entity.ToTable("country_currencies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryBaseId).HasColumnName("country_base_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("currency_code");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(50)
                .HasColumnName("currency_name");
            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(50)
                .HasColumnName("currency_symbol");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CountryBase).WithMany(p => p.CountryCurrencies)
                .HasForeignKey(d => d.CountryBaseId)
                .HasConstraintName("country_base_currencies_id_foreign");
        });

        modelBuilder.Entity<CountryDiallingCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__country___3213E83FE404BEE4");

            entity.ToTable("country_dialling_codes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryBaseId).HasColumnName("country_base_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DiallingCode)
                .HasMaxLength(10)
                .HasColumnName("dialling_code");
            entity.Property(e => e.DiallingCodeNoPrefix)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dialling_code_no_prefix");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CountryBase).WithMany(p => p.CountryDiallingCodes)
                .HasForeignKey(d => d.CountryBaseId)
                .HasConstraintName("country_base_id_foreign");
        });

        modelBuilder.Entity<CountryLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__country___3213E83F70271E83");

            entity.ToTable("country_languages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryBaseId).HasColumnName("country_base_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("language_code");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(100)
                .HasColumnName("language_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CountryBase).WithMany(p => p.CountryLanguages)
                .HasForeignKey(d => d.CountryBaseId)
                .HasConstraintName("country_base_languages_id_foreign");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__currency__3213E83F5A0D1120");

            entity.ToTable("currency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrencyBase)
                .HasMaxLength(255)
                .HasColumnName("currency_base");
            entity.Property(e => e.CurrencyDescription)
                .HasMaxLength(255)
                .HasColumnName("currency_description");
            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("currency_symbol");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__documenttypes__4C2D115822CC164E");

            entity.ToTable("document_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.DocumentSlug)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("document_slug");
            entity.Property(e => e.FolderName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("folder_name");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<EmailLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__email_lo__3213E83F5F5AF675");

            entity.ToTable("email_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttemptCount).HasColumnName("attempt_count");
            entity.Property(e => e.BccAddress).HasColumnName("bcc_address");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CcAddress).HasColumnName("cc_address");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.ErrorMessage).HasColumnName("error_message");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(100)
                .HasColumnName("external_reference");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(255)
                .HasColumnName("from_address");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.IsSuccess).HasColumnName("is_success");
            entity.Property(e => e.JsonMessage).HasColumnName("json_message");
            entity.Property(e => e.LastAttemptDate)
                .HasColumnType("datetime")
                .HasColumnName("last_attempt_date");
            entity.Property(e => e.MessageTypeId).HasColumnName("message_type_id");
            entity.Property(e => e.Provider)
                .HasMaxLength(100)
                .HasColumnName("provider");
            entity.Property(e => e.ReplyToAddress)
                .HasMaxLength(255)
                .HasColumnName("reply_to_address");
            entity.Property(e => e.SentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.Subject)
                .HasMaxLength(500)
                .HasColumnName("subject");
            entity.Property(e => e.ToAddress).HasColumnName("to_address");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.MessageType).WithMany(p => p.EmailLogs)
                .HasForeignKey(d => d.MessageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_email_logs_email_types");
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__email_templates_id");

            entity.ToTable("email_templates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EmailBody).HasColumnName("email_body");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email_subject");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<EmailTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__email_tr__3214EC07EF05BFA6");

            entity.ToTable("email_tracking");

            entity.Property(e => e.EmailId).HasColumnName("email_id");
            entity.Property(e => e.EmailId1)
                .HasMaxLength(255)
                .HasColumnName("EmailId");
            entity.Property(e => e.IpAddress).HasMaxLength(100);
            entity.Property(e => e.OpenedAt).HasColumnType("datetime");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UserAgent).HasMaxLength(500);
        });

        modelBuilder.Entity<EmailType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__email_ty__3213E83FF84ADD91");

            entity.ToTable("email_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<EnquiryType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__enquiry___3213E83FF124D881");

            entity.ToTable("enquiry_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ErrorLogs_id");

            entity.ToTable("error_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CallingFunction).HasMaxLength(250);
            entity.Property(e => e.CallingScreen).HasMaxLength(250);
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<FormCapture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__form_cap__3213E83F20148176");

            entity.ToTable("form_captures");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignedUserId)
                .HasDefaultValue(0L)
                .HasColumnName("assigned_user_id");
            entity.Property(e => e.Complete)
                .HasDefaultValue(false)
                .HasColumnName("complete");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.FormPayload).HasColumnName("form_payload");
            entity.Property(e => e.FormTypeId).HasColumnName("form_type_id");
            entity.Property(e => e.LoggedInUserId)
                .HasDefaultValue(0L)
                .HasColumnName("logged_in_user_id");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.SubFormTypeId).HasColumnName("sub_form_type_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.AssignedUser).WithMany(p => p.FormCaptures)
                .HasForeignKey(d => d.AssignedUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("form_captures_assigned_user_id_foreign");

            entity.HasOne(d => d.FormType).WithMany(p => p.FormCaptures)
                .HasForeignKey(d => d.FormTypeId)
                .HasConstraintName("form_captures_type_id_foreign");

            entity.HasOne(d => d.Site).WithMany(p => p.FormCaptures)
                .HasForeignKey(d => d.SiteId)
                .HasConstraintName("form_captures_site_id_foreign");

            entity.HasOne(d => d.SubFormType).WithMany(p => p.FormCaptures)
                .HasForeignKey(d => d.SubFormTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("form_captures_sub_form_type_id_foreign");
        });

        modelBuilder.Entity<FormCapturesNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__form_cap_note__3213E83F7E572BA5");

            entity.ToTable("form_captures_notes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.FormCaptureId).HasColumnName("form_capture_id");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<FormType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__form_typ__3213E83FAD914D33");

            entity.ToTable("form_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.FormTypeModel).HasColumnName("form_type_model");
            entity.Property(e => e.HasSubForm)
                .HasDefaultValue(false)
                .HasColumnName("has_sub_form");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Company).WithMany(p => p.FormTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("form_type_company_id_foreign");
        });

        modelBuilder.Entity<GlobalSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__global_s__3213E83F2DD6B5FD");

            entity.ToTable("global_settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.SettingModelValue).HasColumnName("setting_model_value");
            entity.Property(e => e.SettingName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("setting_name");
            entity.Property(e => e.SettingValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("setting_value");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<IataAirlineCodesCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iata_airline_codes_countries", "location");

            entity.Property(e => e.AirportName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("airport_name");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.IataCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("iata_code");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("location");
        });

        modelBuilder.Entity<Integration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__integrat__3213E83FB848001E");

            entity.ToTable("integrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IntegrationModel).HasColumnName("integration_model");
            entity.Property(e => e.IntegrationTypeId).HasColumnName("integration_type_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .HasColumnName("logo");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.IntegrationType).WithMany(p => p.Integrations)
                .HasForeignKey(d => d.IntegrationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("integration_type_id_foreign");
        });

        modelBuilder.Entity<IntegrationAuditlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__integrat__3213E83F448FCC37");

            entity.ToTable("integration_auditlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DateRan)
                .HasColumnType("datetime")
                .HasColumnName("date_ran");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.FailedJobs).HasColumnName("failed_jobs");
            entity.Property(e => e.NumberOfCycles).HasColumnName("number_of_cycles");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.SuccessfulJobs).HasColumnName("successful_jobs");
            entity.Property(e => e.TotalJobs).HasColumnName("total_jobs");
        });

        modelBuilder.Entity<IntegrationAuditlogJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__integrat__3213E83FBD27141F");

            entity.ToTable("integration_auditlog_jobs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.IntegrationAuditlogId).HasColumnName("integration_auditlog_id");
            entity.Property(e => e.IntegrationId).HasColumnName("integration_id");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IntegrationAuditlog).WithMany(p => p.IntegrationAuditlogJobs)
                .HasForeignKey(d => d.IntegrationAuditlogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__integrati__integ__0C1BC9F9");
        });

        modelBuilder.Entity<IntegrationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__integrat__3213E83F268284C9");

            entity.ToTable("integration_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(1000)
                .HasColumnName("image_url");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<IpAddressWhitelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ip_addre__3213E83F3DF88588");

            entity.ToTable("ip_address_whitelist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasColumnName("ip_address");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .HasColumnName("label");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__menu_ite__3213E83FA1147949");

            entity.ToTable("menu_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("active_link");
            entity.Property(e => e.Base)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("base");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.HasSubRoute)
                .HasDefaultValue(false)
                .HasColumnName("has_sub_route");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Route)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("route");
            entity.Property(e => e.ShowSubRoute)
                .HasDefaultValue(false)
                .HasColumnName("show_sub_route");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Module).WithMany(p => p.MenuItems)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("modules_has_menu_items_id_foreign");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__modules__3213E83FA7F6CC37");

            entity.ToTable("modules");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.ModuleImageUrl)
                .HasMaxLength(150)
                .HasColumnName("module_image_url");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ShowAsTab)
                .HasDefaultValue(true)
                .HasColumnName("show_as_tab");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<OrganisationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__organisa__3213E83FFA5ECCE5");

            entity.ToTable("organisation_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<PackageType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__package___3213E83FD01B8361");

            entity.ToTable("package_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__permissi__3213E83F6404609F");

            entity.ToTable("permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__regions__3213E83F4394B7C8");

            entity.ToTable("regions", "location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Flag)
                .HasDefaultValue(true)
                .HasColumnName("flag");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Translations).HasColumnName("translations");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83FCA4D2786");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<RoleHasPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__role_has__3213E83FD9D7875F");

            entity.ToTable("role_has_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Permission).WithMany(p => p.RoleHasPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("role_has_permissions_permission_id_foreign");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleHasPermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("role_has_permissions_role_id_foreign");
        });

        modelBuilder.Entity<RouteExclusion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__route_ex__3213E83F690BF957");

            entity.ToTable("route_exclusion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.RequestMethod)
                .HasMaxLength(10)
                .HasColumnName("request_method");
            entity.Property(e => e.RequestPath)
                .HasMaxLength(512)
                .HasColumnName("request_path");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sites__3213E83F6F494908");

            entity.ToTable("sites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Location)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.LocationLat)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("location_lat");
            entity.Property(e => e.LocationLong)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("location_long");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SiteTypeId).HasColumnName("site_type_id");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");

            entity.HasOne(d => d.Company).WithMany(p => p.Sites)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("site_company_id_foreign");

            entity.HasOne(d => d.SiteType).WithMany(p => p.Sites)
                .HasForeignKey(d => d.SiteTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_type_id_foreign");
        });

        modelBuilder.Entity<SiteApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_app__3213E83F2FE6622C");

            entity.ToTable("site_application");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Application).WithMany(p => p.SiteApplications)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("site_application_id_foreign");

            entity.HasOne(d => d.Site).WithMany(p => p.SiteApplications)
                .HasForeignKey(d => d.SiteId)
                .HasConstraintName("site_application_site_id_foreign");
        });

        modelBuilder.Entity<SiteApplicationUserSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_app__3213E83F6A941C21");

            entity.ToTable("site_application_user_site");

            entity.HasIndex(e => new { e.UserSiteId, e.SiteApplicationId }, "uq_userSiteIdSiteApplicationId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.SiteApplicationId).HasColumnName("site_application_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserSiteId).HasColumnName("user_site_id");

            entity.HasOne(d => d.SiteApplication).WithMany(p => p.SiteApplicationUserSites)
                .HasForeignKey(d => d.SiteApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_application_user_site_application_id_foreign");

            entity.HasOne(d => d.UserSite).WithMany(p => p.SiteApplicationUserSites)
                .HasForeignKey(d => d.UserSiteId)
                .HasConstraintName("site_application_user_site_id_foreign");
        });

        modelBuilder.Entity<SiteApplicationUserSiteApplicationRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_app__3213E83F59D439F5");

            entity.ToTable("site_application_user_site_application_roles");

            entity.HasIndex(e => e.SiteApplicationUserSiteId, "uq_siteApplicationUserSiteId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationRoleId).HasColumnName("application_role_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.SiteApplicationUserSiteId).HasColumnName("site_application_user_site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.ApplicationRole).WithMany(p => p.SiteApplicationUserSiteApplicationRoles)
                .HasForeignKey(d => d.ApplicationRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_application_user_site_application_role_id_foreign");

            entity.HasOne(d => d.SiteApplicationUserSite).WithOne(p => p.SiteApplicationUserSiteApplicationRole)
                .HasForeignKey<SiteApplicationUserSiteApplicationRole>(d => d.SiteApplicationUserSiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_site_application_user_site_id_foreign");
        });

        modelBuilder.Entity<SiteApplicationUserSiteApplicationRolesPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_app__3213E83FA5C9771C");

            entity.ToTable("site_application_user_site_application_roles_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationPermissionId).HasColumnName("application_permission_id");
            entity.Property(e => e.ApplicationRoleId).HasColumnName("application_role_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.SiteApplicationUserSiteApplicationRolesId).HasColumnName("site_application_user_site_application_roles_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.ApplicationPermission).WithMany(p => p.SiteApplicationUserSiteApplicationRolesPermissions)
                .HasForeignKey(d => d.ApplicationPermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_application_user_site_application_roles_permissions_application_permission_id_foreign");

            entity.HasOne(d => d.ApplicationRole).WithMany(p => p.SiteApplicationUserSiteApplicationRolesPermissions)
                .HasForeignKey(d => d.ApplicationRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_application_user_site_application_roles_permissions_application_role_id_foreign");

            entity.HasOne(d => d.SiteApplicationUserSiteApplicationRoles).WithMany(p => p.SiteApplicationUserSiteApplicationRolesPermissions)
                .HasForeignKey(d => d.SiteApplicationUserSiteApplicationRolesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_application_user_site_application_roles_permissions_id_foreign");
        });

        modelBuilder.Entity<SiteAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_ass__3213E83F420405D3");

            entity.ToTable("site_assets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetTypeId).HasColumnName("asset_type_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("content_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.Folder)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("folder");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.S3Key)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("s3_key");
            entity.Property(e => e.S3ObjectUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("s3_object_url");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.AssetType).WithMany(p => p.SiteAssets)
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_asset_type_id_foreign");

            entity.HasOne(d => d.Site).WithMany(p => p.SiteAssets)
                .HasForeignKey(d => d.SiteId)
                .HasConstraintName("site_asset_site_id_foreign");
        });

        modelBuilder.Entity<SiteSmsCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__company___3213E83F13265F72");

            entity.ToTable("site_sms_credits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.CreditAmount).HasColumnName("credit_amount");
            entity.Property(e => e.CreditsUsed).HasColumnName("credits_used");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.WarningThreshold)
                .HasDefaultValue(10L)
                .HasColumnName("warning_threshold");

            entity.HasOne(d => d.Site).WithMany(p => p.SiteSmsCredits)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_company_sms_credits_site_id");
        });

        modelBuilder.Entity<SiteTravelGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_tra__3213E83F2C6CD411");

            entity.ToTable("site_travel_groups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Site).WithMany(p => p.SiteTravelGroups)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("site_travel_groups_site_id_foreign");
        });

        modelBuilder.Entity<SiteType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__site_typ__3213E83F68A34797");

            entity.ToTable("site_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms__3213E83F0E732C93");

            entity.ToTable("sms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId).HasColumnName("batch_id");
            entity.Property(e => e.CampaignId).HasColumnName("campaign_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsLive)
                .HasDefaultValue(true)
                .HasColumnName("is_live");
            entity.Property(e => e.LoggedInUserId).HasColumnName("logged_in_user_id");
            entity.Property(e => e.MessageContent)
                .HasMaxLength(1000)
                .HasColumnName("message_content");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.QueuedAt)
                .HasColumnType("datetime")
                .HasColumnName("queued_at");
            entity.Property(e => e.RecipientId).HasColumnName("recipient_id");
            entity.Property(e => e.RecipientName)
                .HasMaxLength(250)
                .HasColumnName("recipient_name");
            entity.Property(e => e.ResponseMessage).HasColumnName("response_message");
            entity.Property(e => e.SentAt)
                .HasColumnType("datetime")
                .HasColumnName("sent_at");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.SmsCreditTierId).HasColumnName("sms_credit_tier_id");
            entity.Property(e => e.SmsTypeId).HasColumnName("sms_type_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.ToNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("to_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Batch).WithMany(p => p.Sms)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("fk_sms_batch");

            entity.HasOne(d => d.Campaign).WithMany(p => p.Sms)
                .HasForeignKey(d => d.CampaignId)
                .HasConstraintName("FK_sms_campaign");

            entity.HasOne(d => d.LoggedInUser).WithMany(p => p.Sms)
                .HasForeignKey(d => d.LoggedInUserId)
                .HasConstraintName("fk_logged_in_user_id");

            entity.HasOne(d => d.Site).WithMany(p => p.Sms)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_site_id");

            entity.HasOne(d => d.SmsType).WithMany(p => p.Sms)
                .HasForeignKey(d => d.SmsTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_smstype");

            entity.HasOne(d => d.Status).WithMany(p => p.Sms)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_status");
        });

        modelBuilder.Entity<SmsBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_batc__3213E83FCE0D63EA");

            entity.ToTable("sms_batch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchName)
                .HasMaxLength(255)
                .HasColumnName("batch_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Processed)
                .HasDefaultValue(false)
                .HasColumnName("processed");
            entity.Property(e => e.RecipientCount).HasColumnName("recipient_count");
            entity.Property(e => e.RetryAttempts).HasColumnName("retry_attempts");
            entity.Property(e => e.ScheduledDatetime)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_datetime");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.SmsCreditTierId).HasColumnName("sms_credit_tier_id");
            entity.Property(e => e.SmsMessage).HasColumnName("sms_message");
            entity.Property(e => e.TotalFailed).HasColumnName("total_failed");
            entity.Property(e => e.TotalSent).HasColumnName("total_sent");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Site).WithMany(p => p.SmsBatches)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_batch_site_id");

            entity.HasOne(d => d.SmsCreditTier).WithMany(p => p.SmsBatches)
                .HasForeignKey(d => d.SmsCreditTierId)
                .HasConstraintName("fk_sms_batch_credit_tier");
        });

        modelBuilder.Entity<SmsBatchDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_batc__3213E83F7E25FFB5");

            entity.ToTable("sms_batch_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId).HasColumnName("batch_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.ToNumber)
                .HasMaxLength(50)
                .HasColumnName("to_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Batch).WithMany(p => p.SmsBatchDetails)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_batch_details_batch");
        });

        modelBuilder.Entity<SmsCampaign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_camp__3213E83FD293C931");

            entity.ToTable("sms_campaign");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CampaignName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("campaign_name");
            entity.Property(e => e.CampaignTypeId).HasColumnName("campaign_type_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("last_run");
            entity.Property(e => e.LoggedInUserId).HasColumnName("logged_in_user_id");
            entity.Property(e => e.MessageBody)
                .HasMaxLength(500)
                .HasColumnName("message_body");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.RecurrenceTypeId).HasColumnName("recurrence_type_id");
            entity.Property(e => e.ScheduledDayOfMonth).HasColumnName("scheduled_day_of_month");
            entity.Property(e => e.ScheduledDayOfWeek)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("scheduled_day_of_week");
            entity.Property(e => e.ScheduledTime).HasColumnName("scheduled_time");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.TotalFailed).HasColumnName("total_failed");
            entity.Property(e => e.TotalSent).HasColumnName("total_sent");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.CampaignType).WithMany(p => p.SmsCampaigns)
                .HasForeignKey(d => d.CampaignTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_campaign_campaign_type");

            entity.HasOne(d => d.LoggedInUser).WithMany(p => p.SmsCampaigns)
                .HasForeignKey(d => d.LoggedInUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sms_campaigns_logged_in_user");

            entity.HasOne(d => d.RecurrenceType).WithMany(p => p.SmsCampaigns)
                .HasForeignKey(d => d.RecurrenceTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_campaign_recurrence_type");

            entity.HasOne(d => d.Site).WithMany(p => p.SmsCampaigns)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_campaign_site");
        });

        modelBuilder.Entity<SmsCampaignType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_camp__3213E83F6A4AD1AB");

            entity.ToTable("sms_campaign_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SmsCreditTier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_cred__3213E83F5F50DFDD");

            entity.ToTable("sms_credit_tiers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.CreditCost).HasColumnName("credit_cost");
            entity.Property(e => e.MaxLength).HasColumnName("max_length");
            entity.Property(e => e.MinLength).HasColumnName("min_length");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmsFailureDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_fail__3213E83F936F511C");

            entity.ToTable("sms_failure_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId).HasColumnName("batch_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.FailureReasons).HasColumnName("failure_reasons");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Batch).WithMany(p => p.SmsFailureDetails)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sms_failure_details_batch");
        });

        modelBuilder.Entity<SmsRecurrenceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_recu__3213E83F3A714182");

            entity.ToTable("sms_recurrence_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IntervalType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("interval_type");
            entity.Property(e => e.IntervalValue).HasColumnName("interval_value");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmsReservedCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_rese__3213E83FF8C41CEC");

            entity.ToTable("sms_reserved_credits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId).HasColumnName("batch_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.ReservedCredits).HasColumnName("reserved_credits");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Batch).WithMany(p => p.SmsReservedCredits)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sms_reserved_credits_batch");

            entity.HasOne(d => d.Site).WithMany(p => p.SmsReservedCredits)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sms_reserved_credits_company");
        });

        modelBuilder.Entity<SmsStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_stat__3213E83F963CCA99");

            entity.ToTable("sms_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .HasColumnName("status_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SmsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sms_type__3213E83F793B129E");

            entity.ToTable("sms_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.SmsTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sms_type_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<SqlQuery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RKA_Syst__id");

            entity.ToTable("sql_queries");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Endpoint)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("endpoint");
            entity.Property(e => e.SqlName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("sql_name");
            entity.Property(e => e.SqlQuery1).HasColumnName("sql_query");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__states__3213E83F7AAA2DA5");

            entity.ToTable("states", "location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country_name");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Flag)
                .HasDefaultValue(true)
                .HasColumnName("flag");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(10, 8)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(11, 8)")
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.StateCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state_code");
            entity.Property(e => e.Type)
                .HasMaxLength(191)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_states_countries");
        });

        modelBuilder.Entity<SubFormType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sub_form__3213E83F81B1DA1C");

            entity.ToTable("sub_form_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.FormTypeId).HasColumnName("form_type_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SubFormTypeModel).HasColumnName("sub_form_type_model");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.FormType).WithMany(p => p.SubFormTypes)
                .HasForeignKey(d => d.FormTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sub_form_type_id_foreign");
        });

        modelBuilder.Entity<Subregion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subregio__3213E83FA6E14AE5");

            entity.ToTable("subregions", "location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Flag)
                .HasDefaultValue(true)
                .HasColumnName("flag");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.Translations).HasColumnName("translations");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");

            entity.HasOne(d => d.Region).WithMany(p => p.Subregions)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_subregions_regions");
        });

        modelBuilder.Entity<Traffic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__traffic__3213E83F11821647");

            entity.ToTable("traffic");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExceptionDetail).HasColumnName("exception_detail");
            entity.Property(e => e.ExceptionMessage).HasColumnName("exception_message");
            entity.Property(e => e.ExceptionType)
                .HasMaxLength(255)
                .HasColumnName("exception_type");
            entity.Property(e => e.RequestBody)
                .IsUnicode(false)
                .HasColumnName("request_body");
            entity.Property(e => e.RequestIpAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("request_ip_address");
            entity.Property(e => e.RequestMethod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("request_method");
            entity.Property(e => e.RequestTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("request_timestamp");
            entity.Property(e => e.RequestUrl)
                .HasMaxLength(2000)
                .HasColumnName("request_url");
            entity.Property(e => e.ResponseStatusCode).HasColumnName("response_status_code");
            entity.Property(e => e.ResponseTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("response_timestamp");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F14355AFB");

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "UC_Email").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0L)
                .HasColumnName("parent_id");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(255)
                .HasColumnName("phone_no");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasColumnName("remember_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserFolder)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("user_folder");
        });

        modelBuilder.Entity<UserAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_acc__3213E83F352E7593");

            entity.ToTable("user_access_tokens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abilities).HasColumnName("abilities");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("expires_at");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastUsedAt)
                .HasColumnType("datetime")
                .HasColumnName("last_used_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Token)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserAccessTokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_access_tokens_user_id_foreign");
        });

        modelBuilder.Entity<UserApplicationRolePermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_application_role_permissions");

            entity.ToTable("user_application_role_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationPermissionId).HasColumnName("application_permission_id");
            entity.Property(e => e.ApplicationRoleId).HasColumnName("application_role_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_com__3213E83F679C179B");

            entity.ToTable("user_company");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .HasColumnName("avatar");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Company).WithMany(p => p.UserCompanies)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("user_company_company_id_foreign");

            entity.HasOne(d => d.User).WithMany(p => p.UserCompanies)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_company_user_id_foreign");
        });

        modelBuilder.Entity<UserHasRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_has__3213E83F70F16DAA");

            entity.ToTable("user_has_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Role).WithMany(p => p.UserHasRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("user_has_roles_role_id_foreign");

            entity.HasOne(d => d.User).WithMany(p => p.UserHasRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_has_roles_user_id_foreign");
        });

        modelBuilder.Entity<UserPasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_password_reset");

            entity.ToTable("user_password_reset_tokens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("expires_at");
            entity.Property(e => e.Token)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserReportingLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_rep__3213E83FF75A9F7F");

            entity.ToTable("user_reporting_line");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.ReportingToId).HasColumnName("reporting_to_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Company).WithMany(p => p.UserReportingLines)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("user_reporting_line_company_id_foreign");

            entity.HasOne(d => d.ReportingTo).WithMany(p => p.UserReportingLineReportingTos)
                .HasForeignKey(d => d.ReportingToId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_reporting_line_reporting_to_id_foreign");

            entity.HasOne(d => d.User).WithMany(p => p.UserReportingLineUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_reporting_line_user_id_foreign");
        });

        modelBuilder.Entity<UserRolePermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_rol__3213E83FC0878DBA");

            entity.ToTable("user_role_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.UserRolePermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("fk_permission_id");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRolePermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("fk_user_role_permission_role_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserRolePermissions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_user_role_permission_user_id");
        });

        modelBuilder.Entity<UserSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_sit__3213E83F619DEB11");

            entity.ToTable("user_site");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Site).WithMany(p => p.UserSites)
                .HasForeignKey(d => d.SiteId)
                .HasConstraintName("user_site_id_foreign");

            entity.HasOne(d => d.User).WithMany(p => p.UserSites)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("site_user_id_foreign");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
