using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Blog
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string SubTitle { get; set; } = null!;

    public string? Author { get; set; }

    public string? BlogContent { get; set; }

    public string? BlogImage { get; set; }

    public bool? IsPublished { get; set; }

    public long PublishedByUserId { get; set; }

    public string? PublishedDate { get; set; }

    public string? BlogSource { get; set; }

    public long CompanyId { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual User PublishedByUser { get; set; } = null!;
}
