using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Subregion
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Translations { get; set; }

    public int RegionId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool Flag { get; set; }

    public string? WikiDataId { get; set; }

    public virtual Region Region { get; set; } = null!;
}
