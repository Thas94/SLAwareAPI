using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsBatch
{
    public long Id { get; set; }

    public string BatchName { get; set; } = null!;

    public long SiteId { get; set; }

    public DateTime? ScheduledDatetime { get; set; }

    public string? SmsMessage { get; set; }

    public bool? IsActive { get; set; }

    public bool? Processed { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int RetryAttempts { get; set; }

    public long RecipientCount { get; set; }

    public long TotalSent { get; set; }

    public long TotalFailed { get; set; }

    public long? SmsCreditTierId { get; set; }

    public virtual Site Site { get; set; } = null!;

    public virtual ICollection<Sm> Sms { get; set; } = new List<Sm>();

    public virtual ICollection<SmsBatchDetail> SmsBatchDetails { get; set; } = new List<SmsBatchDetail>();

    public virtual SmsCreditTier? SmsCreditTier { get; set; }

    public virtual ICollection<SmsFailureDetail> SmsFailureDetails { get; set; } = new List<SmsFailureDetail>();

    public virtual ICollection<SmsReservedCredit> SmsReservedCredits { get; set; } = new List<SmsReservedCredit>();
}
