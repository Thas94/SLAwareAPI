using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class ConfigurationType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? ConfigurationModel { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CompanyConfiguration> CompanyConfigurations { get; set; } = new List<CompanyConfiguration>();
}
