using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyIntegration
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long IntegrationId { get; set; }

    public string? SettingsPayload { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsActive { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Integration Integration { get; set; } = null!;
}
