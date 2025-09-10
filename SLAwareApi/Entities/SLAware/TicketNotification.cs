using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class TicketNotification
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public long UserId { get; set; }

    public string Message { get; set; } = null!;

    public bool? IsRead { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
