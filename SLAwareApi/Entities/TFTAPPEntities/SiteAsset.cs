using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SiteAsset
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public long AssetTypeId { get; set; }

    public string Folder { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string ContentType { get; set; } = null!;

    public long FileSize { get; set; }

    public string S3Key { get; set; } = null!;

    public string S3ObjectUrl { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AssetType AssetType { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;
}
