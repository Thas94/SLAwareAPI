using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Role
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<RoleHasPermission> RoleHasPermissions { get; set; } = new List<RoleHasPermission>();

    public virtual ICollection<UserHasRole> UserHasRoles { get; set; } = new List<UserHasRole>();

    public virtual ICollection<UserRolePermission> UserRolePermissions { get; set; } = new List<UserRolePermission>();
}
