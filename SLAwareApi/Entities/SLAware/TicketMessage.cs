using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class TicketMessage
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public string MessageContent { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
