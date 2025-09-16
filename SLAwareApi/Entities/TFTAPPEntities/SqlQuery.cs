using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SqlQuery
{
    public int Id { get; set; }

    public string SqlName { get; set; } = null!;

    public string Endpoint { get; set; } = null!;

    public string SqlQuery1 { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
