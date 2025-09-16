using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class ApplicationRolesHasPermission
{
    public long Id { get; set; }

    public long ApplicationPermissionsId { get; set; }

    public long ApplicationRoleId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
