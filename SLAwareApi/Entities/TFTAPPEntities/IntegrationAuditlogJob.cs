using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class IntegrationAuditlogJob
{
    public long Id { get; set; }

    public long IntegrationAuditlogId { get; set; }

    public string? Name { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public long? Duration { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public long? IntegrationId { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual IntegrationAuditlog IntegrationAuditlog { get; set; } = null!;
}
