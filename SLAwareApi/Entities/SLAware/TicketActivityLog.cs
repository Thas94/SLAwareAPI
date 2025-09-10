using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class TicketActivityLog
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public long UserId { get; set; }

    public string Description { get; set; } = null!;

    public long OldTicketStatusId { get; set; }

    public long? NewTicketStatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
