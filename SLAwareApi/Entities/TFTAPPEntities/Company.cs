using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Company
{
    public long Id { get; set; }

    public string TradingName { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string RegistrationNumber { get; set; } = null!;

    public bool? IsVatRegistered { get; set; }

    public string? VatNo { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string StreetAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Province { get; set; } = null!;

    public string Country { get; set; } = null!;

    public long PostalCode { get; set; }

    public string? Website { get; set; }

    public int? ParentId { get; set; }

    public int? OrganisationTypeId { get; set; }

    public int CompanyTypeId { get; set; }

    public string? Logo { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? IataNo { get; set; }

    public string? Pcc { get; set; }

    public string? Gds { get; set; }

    public virtual ICollection<AdditionalCompanyRole> AdditionalCompanyRoles { get; set; } = new List<AdditionalCompanyRole>();

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    public virtual ICollection<CompanyAppRoleHierarchy> CompanyAppRoleHierarchies { get; set; } = new List<CompanyAppRoleHierarchy>();

    public virtual ICollection<CompanyApplication> CompanyApplications { get; set; } = new List<CompanyApplication>();

    public virtual ICollection<CompanyConfiguration> CompanyConfigurations { get; set; } = new List<CompanyConfiguration>();

    public virtual ICollection<CompanyIntegration> CompanyIntegrations { get; set; } = new List<CompanyIntegration>();

    public virtual CompanyType CompanyType { get; set; } = null!;

    public virtual ICollection<CompanyUserDocumentTypeS3Object> CompanyUserDocumentTypeS3Objects { get; set; } = new List<CompanyUserDocumentTypeS3Object>();

    public virtual ICollection<FormType> FormTypes { get; set; } = new List<FormType>();

    public virtual OrganisationType? OrganisationType { get; set; }

    public virtual ICollection<Site> Sites { get; set; } = new List<Site>();

    public virtual ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();

    public virtual ICollection<UserReportingLine> UserReportingLines { get; set; } = new List<UserReportingLine>();
}
