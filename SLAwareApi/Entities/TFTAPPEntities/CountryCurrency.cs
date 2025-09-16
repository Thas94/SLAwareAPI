using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CountryCurrency
{
    public long Id { get; set; }

    public long CountryBaseId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyName { get; set; }

    public string? CurrencySymbol { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CountryBase CountryBase { get; set; } = null!;
}
