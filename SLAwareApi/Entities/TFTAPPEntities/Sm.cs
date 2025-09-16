using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class Sm
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public string ToNumber { get; set; } = null!;

    public string MessageContent { get; set; } = null!;

    public string? ResponseMessage { get; set; }

    public long SmsTypeId { get; set; }

    public long StatusId { get; set; }

    public bool Processed { get; set; }

    public bool IsLive { get; set; }

    public DateTime? QueuedAt { get; set; }

    public DateTime? SentAt { get; set; }

    public long? LoggedInUserId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? BatchId { get; set; }

    public long? SmsCreditTierId { get; set; }

    public long? CampaignId { get; set; }

    public long? RecipientId { get; set; }

    public string? RecipientName { get; set; }

    public virtual SmsBatch? Batch { get; set; }

    public virtual SmsCampaign? Campaign { get; set; }

    public virtual User? LoggedInUser { get; set; }

    public virtual Site Site { get; set; } = null!;

    public virtual SmsType SmsType { get; set; } = null!;

    public virtual SmsStatus Status { get; set; } = null!;
}
