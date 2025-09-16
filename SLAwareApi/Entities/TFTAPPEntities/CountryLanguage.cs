using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CountryLanguage
{
    public long Id { get; set; }

    public long CountryBaseId { get; set; }

    public string? LanguageCode { get; set; }

    public string? LanguageName { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CountryBase CountryBase { get; set; } = null!;
}
