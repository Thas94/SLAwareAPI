using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Application
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? ApplicationImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApplicationHasModule> ApplicationHasModules { get; set; } = new List<ApplicationHasModule>();

    public virtual ICollection<CompanyApplication> CompanyApplications { get; set; } = new List<CompanyApplication>();

    public virtual ICollection<SiteApplication> SiteApplications { get; set; } = new List<SiteApplication>();
}
