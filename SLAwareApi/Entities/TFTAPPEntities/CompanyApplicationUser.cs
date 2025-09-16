using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyApplicationUser
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long CompanyApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CompanyApplication CompanyApplication { get; set; } = null!;

    public virtual ICollection<CompanyApplicationUserRole> CompanyApplicationUserRoles { get; set; } = new List<CompanyApplicationUserRole>();

    public virtual User User { get; set; } = null!;
}
