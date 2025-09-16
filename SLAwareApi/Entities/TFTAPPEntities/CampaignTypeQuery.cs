using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CampaignTypeQuery
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long CampaignTypeId { get; set; }

    public string QueryName { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual SmsCampaignType CampaignType { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;
}
