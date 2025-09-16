using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int StateId { get; set; }

    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public int CountryId { get; set; }

    public string CountryCode { get; set; } = null!;

    public string? CountryName { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool Flag { get; set; }

    public string? WikiDataId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual State State { get; set; } = null!;
}
