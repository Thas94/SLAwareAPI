using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SiteApplicationUserSiteApplicationRolesPermission
{
    public long Id { get; set; }

    public long SiteApplicationUserSiteApplicationRolesId { get; set; }

    public long ApplicationRoleId { get; set; }

    public long ApplicationPermissionId { get; set; }

    public bool Enabled { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ApplicationPermission ApplicationPermission { get; set; } = null!;

    public virtual ApplicationRole ApplicationRole { get; set; } = null!;

    public virtual SiteApplicationUserSiteApplicationRole SiteApplicationUserSiteApplicationRoles { get; set; } = null!;
}
