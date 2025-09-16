using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SiteSmsCredit
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long CreditAmount { get; set; }

    public long WarningThreshold { get; set; }

    public long CreditsUsed { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Site Site { get; set; } = null!;
}
