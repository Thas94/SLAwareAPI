using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyAuditLog
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

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

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
