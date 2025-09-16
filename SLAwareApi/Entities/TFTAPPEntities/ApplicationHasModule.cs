using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class ApplicationHasModule
{
    public long Id { get; set; }

    public long ApplicationId { get; set; }

    public long ModuleId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual Module Module { get; set; } = null!;
}
