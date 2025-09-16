using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class CompanyUserDocumentTypeS3Object
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long UserId { get; set; }

    public long DocumentTypeId { get; set; }

    public string S3Key { get; set; } = null!;

    public string S3ObjectUrl { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
