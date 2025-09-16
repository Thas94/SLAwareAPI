using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SiteApplication
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long ApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;

    public virtual ICollection<SiteApplicationUserSite> SiteApplicationUserSites { get; set; } = new List<SiteApplicationUserSite>();
}
