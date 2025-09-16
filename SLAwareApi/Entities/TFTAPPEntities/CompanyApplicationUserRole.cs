using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyApplicationUserRole
{
    public long Id { get; set; }

    public long CompanyApplicationUserId { get; set; }

    public long ApplicationRoleId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ApplicationRole ApplicationRole { get; set; } = null!;

    public virtual CompanyApplicationUser CompanyApplicationUser { get; set; } = null!;
}
