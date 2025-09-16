using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SiteApplicationUserSiteApplicationRole
{
    public long Id { get; set; }

    public long SiteApplicationUserSiteId { get; set; }

    public long ApplicationRoleId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ApplicationRole ApplicationRole { get; set; } = null!;

    public virtual SiteApplicationUserSite SiteApplicationUserSite { get; set; } = null!;

    public virtual ICollection<SiteApplicationUserSiteApplicationRolesPermission> SiteApplicationUserSiteApplicationRolesPermissions { get; set; } = new List<SiteApplicationUserSiteApplicationRolesPermission>();
}
