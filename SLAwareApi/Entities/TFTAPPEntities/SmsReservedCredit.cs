using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsReservedCredit
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long BatchId { get; set; }

    public long ReservedCredits { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool Processed { get; set; }

    public virtual SmsBatch Batch { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;
}
