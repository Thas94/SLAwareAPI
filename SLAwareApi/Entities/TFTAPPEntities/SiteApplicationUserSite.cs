using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SiteApplicationUserSite
{
    public long Id { get; set; }

    public long UserSiteId { get; set; }

    public long SiteApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual SiteApplication SiteApplication { get; set; } = null!;

    public virtual SiteApplicationUserSiteApplicationRole? SiteApplicationUserSiteApplicationRole { get; set; }

    public virtual UserSite UserSite { get; set; } = null!;
}
