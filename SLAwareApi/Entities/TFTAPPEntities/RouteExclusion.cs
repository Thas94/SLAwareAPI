using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class RouteExclusion
{
    public long Id { get; set; }

    public string? RequestMethod { get; set; }

    public string RequestPath { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }
}
