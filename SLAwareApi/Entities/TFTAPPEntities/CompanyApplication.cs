using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyApplication
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long ApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<CompanyApplicationModule> CompanyApplicationModules { get; set; } = new List<CompanyApplicationModule>();

    public virtual ICollection<CompanyApplicationUser> CompanyApplicationUsers { get; set; } = new List<CompanyApplicationUser>();
}
