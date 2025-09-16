using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class EmailTracking
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long EmailId { get; set; }

    public string? EmailId1 { get; set; }

    public DateTime? OpenedAt { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }
}
