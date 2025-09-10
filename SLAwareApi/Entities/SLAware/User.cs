using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class User
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long ClientTierId { get; set; }
}
