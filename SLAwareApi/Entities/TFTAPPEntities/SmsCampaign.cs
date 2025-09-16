using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class SmsCampaign
{
    public long Id { get; set; }

    public long SiteId { get; set; }

    public string CampaignName { get; set; } = null!;

    public string MessageBody { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long CampaignTypeId { get; set; }

    public long RecurrenceTypeId { get; set; }

    public string? ScheduledDayOfWeek { get; set; }

    public int? ScheduledDayOfMonth { get; set; }

    public DateTime? LastRun { get; set; }

    public bool? IsActive { get; set; }

    public long TotalSent { get; set; }

    public long TotalFailed { get; set; }

    public bool Processed { get; set; }

    public long LoggedInUserId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public TimeOnly? ScheduledTime { get; set; }

    public virtual SmsCampaignType CampaignType { get; set; } = null!;

    public virtual User LoggedInUser { get; set; } = null!;

    public virtual SmsRecurrenceType RecurrenceType { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;

    public virtual ICollection<Sm> Sms { get; set; } = new List<Sm>();
}
