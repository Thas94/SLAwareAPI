using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class Ticket
{
    public long Id { get; set; }

    public long TicketNumber { get; set; }

    public string Subject { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long TicketStatusId { get; set; }

    public long CreatedById { get; set; }

    public long? AssignedToId { get; set; }

    public DateTime ResponseDueDtm { get; set; }

    public DateTime ResolutionDueDtm { get; set; }

    public DateTime? RemainingResponseDueDtm { get; set; }

    public DateTime? RemainingResolutionDueDtm { get; set; }

    public DateTime? PausedDtm { get; set; }

    public DateTime? ResolvedDtm { get; set; }

    public long SlaSeverityLevelId { get; set; }

    public bool? IsResponseSlaBreach { get; set; }

    public bool? IsResolutionSlaBreach { get; set; }

    public DateTime CreatedAt { get; set; }
}
