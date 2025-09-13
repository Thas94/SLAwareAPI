using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class SlaSeverityLevel
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual ICollection<SlaSeverityLevelRule> SlaSeverityLevelRules { get; set; } = new List<SlaSeverityLevelRule>();

    public virtual TicketSlaTracking? TicketSlaTracking { get; set; }
}
