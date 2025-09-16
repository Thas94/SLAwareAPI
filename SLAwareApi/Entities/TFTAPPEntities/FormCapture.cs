using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class FormCapture
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long? AssignedUserId { get; set; }

    public long? LoggedInUserId { get; set; }

    public long FormTypeId { get; set; }

    public long? SubFormTypeId { get; set; }

    public string FormPayload { get; set; } = null!;

    public bool? Complete { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User? AssignedUser { get; set; }

    public virtual FormType FormType { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;

    public virtual SubFormType? SubFormType { get; set; }
}
