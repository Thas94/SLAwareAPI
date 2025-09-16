using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class UserAccessToken
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string? Name { get; set; }

    public string? Token { get; set; }

    public string? Abilities { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUsedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
