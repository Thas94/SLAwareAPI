using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class ErrorLog
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public string? CallingScreen { get; set; }

    public string? CallingFunction { get; set; }

    public string? ErrorMessage { get; set; }

    public string? StackTrace { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
