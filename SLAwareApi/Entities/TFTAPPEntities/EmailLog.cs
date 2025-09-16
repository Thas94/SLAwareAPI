using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class EmailLog
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public long? SiteId { get; set; }

    public long? UserId { get; set; }

    public string FromAddress { get; set; } = null!;

    public string? ReplyToAddress { get; set; }

    public string ToAddress { get; set; } = null!;

    public string? CcAddress { get; set; }

    public string? BccAddress { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? JsonMessage { get; set; }

    public string? Provider { get; set; }

    public int MessageTypeId { get; set; }

    public string? ExternalReference { get; set; }

    public bool IsSuccess { get; set; }

    public string? ErrorMessage { get; set; }

    public int AttemptCount { get; set; }

    public DateTime? LastAttemptDate { get; set; }

    public DateTime SentDate { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual EmailType MessageType { get; set; } = null!;
}
