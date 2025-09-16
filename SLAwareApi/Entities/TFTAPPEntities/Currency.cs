using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Currency
{
    public long Id { get; set; }

    public string CurrencyBase { get; set; } = null!;

    public string CurrencyDescription { get; set; } = null!;

    public string? CurrencySymbol { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
