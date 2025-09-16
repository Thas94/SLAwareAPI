using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class UserRolePermission
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long RoleId { get; set; }

    public long PermissionId { get; set; }

    public bool Enabled { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Permission Permission { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
