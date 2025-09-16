using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class UserApplicationRolePermission
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long UserId { get; set; }

    public long ApplicationRoleId { get; set; }

    public long ApplicationPermissionId { get; set; }

    public bool Enabled { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
