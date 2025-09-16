using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsBatchDetail
{
    public long Id { get; set; }

    public long BatchId { get; set; }

    public string ToNumber { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual SmsBatch Batch { get; set; } = null!;
}
