using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class DocumentType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DocumentSlug { get; set; }

    public string? FolderName { get; set; }

    public virtual ICollection<CompanyUserDocumentTypeS3Object> CompanyUserDocumentTypeS3Objects { get; set; } = new List<CompanyUserDocumentTypeS3Object>();
}
