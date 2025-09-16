using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CountryDiallingCode
{
    public long Id { get; set; }

    public long CountryBaseId { get; set; }

    public string DiallingCode { get; set; } = null!;

    public string DiallingCodeNoPrefix { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CountryBase CountryBase { get; set; } = null!;
}
