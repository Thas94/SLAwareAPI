using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class EmailTemplate
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public string Description { get; set; } = null!;

    public string EmailSubject { get; set; } = null!;

    public string EmailBody { get; set; } = null!;

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
