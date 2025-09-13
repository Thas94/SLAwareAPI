using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class TicketSlaTracking
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public long SlaSeverityLevelId { get; set; }

    public DateTime ResponseDueDtm { get; set; }

    public DateTime ResolutionDueDtm { get; set; }

    public DateTime? RemainingResponseDueDtm { get; set; }

    public DateTime? RemainingResolutionDueDtm { get; set; }

    public DateTime? PausedDtm { get; set; }

    public DateTime? ResolvedDtm { get; set; }

    public DateTime? IsResponseSlaBreach { get; set; }

    public DateTime? IsResolutionSlaBreach { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual SlaSeverityLevel IdNavigation { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
