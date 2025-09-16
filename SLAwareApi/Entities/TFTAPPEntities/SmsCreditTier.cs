using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsCreditTier
{
    public long Id { get; set; }

    public int MinLength { get; set; }

    public int MaxLength { get; set; }

    public int CreditCost { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<SmsBatch> SmsBatches { get; set; } = new List<SmsBatch>();
}
