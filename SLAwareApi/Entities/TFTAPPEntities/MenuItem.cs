using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class MenuItem
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Route { get; set; } = null!;

    public string ActiveLink { get; set; } = null!;

    public bool? HasSubRoute { get; set; }

    public bool? ShowSubRoute { get; set; }

    public string? Icon { get; set; }

    public string? Base { get; set; }

    public long ModuleId { get; set; }

    public bool? IsActive { get; set; }

    public int SortOrder { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Module Module { get; set; } = null!;
}
