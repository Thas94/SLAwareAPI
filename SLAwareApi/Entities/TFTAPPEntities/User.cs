using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class User
{
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? EmailVerifiedAt { get; set; }

    public string Password { get; set; } = null!;

    public string? RememberToken { get; set; }

    public bool? IsActive { get; set; }

    public long? ParentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UserFolder { get; set; }

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    public virtual ICollection<CompanyApplicationUser> CompanyApplicationUsers { get; set; } = new List<CompanyApplicationUser>();

    public virtual ICollection<CompanyUserDocumentTypeS3Object> CompanyUserDocumentTypeS3Objects { get; set; } = new List<CompanyUserDocumentTypeS3Object>();

    public virtual ICollection<FormCapture> FormCaptures { get; set; } = new List<FormCapture>();

    public virtual ICollection<Sm> Sms { get; set; } = new List<Sm>();

    public virtual ICollection<SmsCampaign> SmsCampaigns { get; set; } = new List<SmsCampaign>();

    public virtual ICollection<UserAccessToken> UserAccessTokens { get; set; } = new List<UserAccessToken>();

    public virtual ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();

    public virtual ICollection<UserHasRole> UserHasRoles { get; set; } = new List<UserHasRole>();

    public virtual ICollection<UserReportingLine> UserReportingLineReportingTos { get; set; } = new List<UserReportingLine>();

    public virtual ICollection<UserReportingLine> UserReportingLineUsers { get; set; } = new List<UserReportingLine>();

    public virtual ICollection<UserRolePermission> UserRolePermissions { get; set; } = new List<UserRolePermission>();

    public virtual ICollection<UserSite> UserSites { get; set; } = new List<UserSite>();
}
