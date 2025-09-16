using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class ApplicationRole
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? ApplicationId { get; set; }

    public virtual ICollection<CompanyAppRoleHierarchy> CompanyAppRoleHierarchyAppRoleParents { get; set; } = new List<CompanyAppRoleHierarchy>();

    public virtual ICollection<CompanyAppRoleHierarchy> CompanyAppRoleHierarchyAppRoles { get; set; } = new List<CompanyAppRoleHierarchy>();

    public virtual ICollection<CompanyApplicationUserRole> CompanyApplicationUserRoles { get; set; } = new List<CompanyApplicationUserRole>();

    public virtual ICollection<SiteApplicationUserSiteApplicationRole> SiteApplicationUserSiteApplicationRoles { get; set; } = new List<SiteApplicationUserSiteApplicationRole>();

    public virtual ICollection<SiteApplicationUserSiteApplicationRolesPermission> SiteApplicationUserSiteApplicationRolesPermissions { get; set; } = new List<SiteApplicationUserSiteApplicationRolesPermission>();
}
