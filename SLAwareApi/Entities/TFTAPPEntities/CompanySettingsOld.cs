using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanySettingsOld
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public string S3Configuration { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
