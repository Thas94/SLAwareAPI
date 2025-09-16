using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Integration
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Logo { get; set; }

    public long IntegrationTypeId { get; set; }

    public string? IntegrationModel { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CompanyIntegration> CompanyIntegrations { get; set; } = new List<CompanyIntegration>();

    public virtual IntegrationType IntegrationType { get; set; } = null!;
}
