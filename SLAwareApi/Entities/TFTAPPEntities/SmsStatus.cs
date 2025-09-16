using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsStatus
{
    public long Id { get; set; }

    public string StatusName { get; set; } = null!;

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Sm> Sms { get; set; } = new List<Sm>();
}
