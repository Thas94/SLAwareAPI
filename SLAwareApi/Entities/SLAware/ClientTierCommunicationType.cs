using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class ClientTierCommunicationType
{
    public long Id { get; set; }

    public long ClientTierId { get; set; }

    public long CommunicationTypeId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;
}
