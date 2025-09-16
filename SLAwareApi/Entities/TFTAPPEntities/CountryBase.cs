using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CountryBase
{
    public long Id { get; set; }

    public string? CountryNameCommon { get; set; }

    public string? CountryNameOfficial { get; set; }

    public string? Alpha2Code { get; set; }

    public string? Alpha3Code { get; set; }

    public string? Timezone { get; set; }

    public string? FlagPng { get; set; }

    public string? FlagSvg { get; set; }

    public string? FlagAlt { get; set; }

    public string? GoogleMapsUrl { get; set; }

    public string? OpenstreetMapsUrl { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? CountryContinentId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual CountryContinent? CountryContinent { get; set; }

    public virtual ICollection<CountryCurrency> CountryCurrencies { get; set; } = new List<CountryCurrency>();

    public virtual ICollection<CountryDiallingCode> CountryDiallingCodes { get; set; } = new List<CountryDiallingCode>();

    public virtual ICollection<CountryLanguage> CountryLanguages { get; set; } = new List<CountryLanguage>();
}
