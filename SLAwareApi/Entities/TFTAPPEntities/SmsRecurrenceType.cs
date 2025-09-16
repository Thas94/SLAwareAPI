using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsRecurrenceType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string IntervalType { get; set; } = null!;

    public long IntervalValue { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<SmsCampaign> SmsCampaigns { get; set; } = new List<SmsCampaign>();
}
