using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyIntegrationBackup20241121
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long IntegrationId { get; set; }

    public string? SettingsPayload { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
