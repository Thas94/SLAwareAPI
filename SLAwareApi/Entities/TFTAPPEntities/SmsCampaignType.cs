using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsCampaignType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CampaignTypeQuery> CampaignTypeQueries { get; set; } = new List<CampaignTypeQuery>();

    public virtual ICollection<SmsCampaign> SmsCampaigns { get; set; } = new List<SmsCampaign>();
}
