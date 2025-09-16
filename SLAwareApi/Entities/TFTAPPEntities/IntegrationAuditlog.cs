using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class IntegrationAuditlog
{
    public long Id { get; set; }

    public DateTime DateRan { get; set; }

    public long? NumberOfCycles { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public long? TotalJobs { get; set; }

    public long? SuccessfulJobs { get; set; }

    public long? FailedJobs { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<IntegrationAuditlogJob> IntegrationAuditlogJobs { get; set; } = new List<IntegrationAuditlogJob>();
}
