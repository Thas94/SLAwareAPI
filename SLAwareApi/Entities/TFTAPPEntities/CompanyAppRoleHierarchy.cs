using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyAppRoleHierarchy
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long AppRoleId { get; set; }

    public long AppRoleParentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ApplicationRole AppRole { get; set; } = null!;

    public virtual ApplicationRole AppRoleParent { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;
}
