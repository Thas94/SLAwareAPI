using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class IpAddressWhitelist
{
    public long Id { get; set; }

    public string IpAddress { get; set; } = null!;

    public string? Label { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }
}
