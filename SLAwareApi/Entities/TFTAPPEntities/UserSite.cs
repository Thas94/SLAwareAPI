using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class UserSite
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long SiteId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Site Site { get; set; } = null!;

    public virtual ICollection<SiteApplicationUserSite> SiteApplicationUserSites { get; set; } = new List<SiteApplicationUserSite>();

    public virtual User User { get; set; } = null!;
}
