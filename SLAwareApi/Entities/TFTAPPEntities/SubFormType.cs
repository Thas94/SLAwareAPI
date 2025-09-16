using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SubFormType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long FormTypeId { get; set; }

    public string? SubFormTypeModel { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<FormCapture> FormCaptures { get; set; } = new List<FormCapture>();

    public virtual FormType FormType { get; set; } = null!;
}
