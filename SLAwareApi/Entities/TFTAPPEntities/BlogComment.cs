using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class BlogComment
{
    public long Id { get; set; }

    public long BlogId { get; set; }

    public long UserId { get; set; }

    public string? BlogComment1 { get; set; }

    public int? Rating { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
