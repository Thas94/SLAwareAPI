using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Site
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? Url { get; set; }

    public long SiteTypeId { get; set; }

    public long CompanyId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Location { get; set; }

    public decimal? LocationLat { get; set; }

    public decimal? LocationLong { get; set; }

    public virtual ICollection<CampaignTypeQuery> CampaignTypeQueries { get; set; } = new List<CampaignTypeQuery>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<FormCapture> FormCaptures { get; set; } = new List<FormCapture>();

    public virtual ICollection<SiteApplication> SiteApplications { get; set; } = new List<SiteApplication>();

    public virtual ICollection<SiteAsset> SiteAssets { get; set; } = new List<SiteAsset>();

    public virtual ICollection<SiteSmsCredit> SiteSmsCredits { get; set; } = new List<SiteSmsCredit>();

    public virtual ICollection<SiteTravelGroup> SiteTravelGroups { get; set; } = new List<SiteTravelGroup>();

    public virtual SiteType SiteType { get; set; } = null!;

    public virtual ICollection<Sm> Sms { get; set; } = new List<Sm>();

    public virtual ICollection<SmsBatch> SmsBatches { get; set; } = new List<SmsBatch>();

    public virtual ICollection<SmsCampaign> SmsCampaigns { get; set; } = new List<SmsCampaign>();

    public virtual ICollection<SmsReservedCredit> SmsReservedCredits { get; set; } = new List<SmsReservedCredit>();

    public virtual ICollection<UserSite> UserSites { get; set; } = new List<UserSite>();
}
