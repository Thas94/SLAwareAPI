using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class BearerToken
{
    public long Id { get; set; }

    public long CompanyConfigurationId { get; set; }

    public string Token { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CompanyConfiguration CompanyConfiguration { get; set; } = null!;
}
