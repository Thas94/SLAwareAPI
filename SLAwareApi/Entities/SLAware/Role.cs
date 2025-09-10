using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class Role
{
    public long Id { get; set; }

    public string RoleName { get; set; } = null!;
}
