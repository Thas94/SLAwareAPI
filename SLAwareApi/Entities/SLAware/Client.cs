using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class Client
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long ClientTierId { get; set; }

    public virtual ClientTier ClientTier { get; set; } = null!;
}
