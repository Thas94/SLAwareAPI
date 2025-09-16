using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyConfiguration
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long ConfigurationTypeId { get; set; }

    public string Configuration { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BearerToken> BearerTokens { get; set; } = new List<BearerToken>();

    public virtual Company Company { get; set; } = null!;

    public virtual ConfigurationType ConfigurationType { get; set; } = null!;
}
