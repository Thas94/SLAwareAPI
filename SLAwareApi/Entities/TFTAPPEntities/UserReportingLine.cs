using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class UserReportingLine
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long UserId { get; set; }

    public long ReportingToId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual User ReportingTo { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
