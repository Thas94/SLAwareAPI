using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class FormType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? FormTypeModel { get; set; }

    public long CompanyId { get; set; }

    public bool? HasSubForm { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<FormCapture> FormCaptures { get; set; } = new List<FormCapture>();

    public virtual ICollection<SubFormType> SubFormTypes { get; set; } = new List<SubFormType>();
}
