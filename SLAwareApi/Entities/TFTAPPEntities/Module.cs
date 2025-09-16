using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Module
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool? ShowAsTab { get; set; }

    public string? ModuleImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApplicationHasModule> ApplicationHasModules { get; set; } = new List<ApplicationHasModule>();

    public virtual ICollection<CompanyApplicationModule> CompanyApplicationModules { get; set; } = new List<CompanyApplicationModule>();

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
