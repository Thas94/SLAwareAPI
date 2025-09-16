using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class ApplicationPermission
{
    public long Id { get; set; }

    public long? ApplicationId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<SiteApplicationUserSiteApplicationRolesPermission> SiteApplicationUserSiteApplicationRolesPermissions { get; set; } = new List<SiteApplicationUserSiteApplicationRolesPermission>();
}
