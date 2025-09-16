using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class SlaSeverityLevel
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public long InitialReponseHours { get; set; }

    public long TargetResolutionHours { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<TicketSlaTracking> TicketSlaTrackings { get; set; } = new List<TicketSlaTracking>();
}
