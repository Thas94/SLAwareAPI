using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.SLAware;

public partial class Traffic
{
    public long Id { get; set; }

    public string RequestIpAddress { get; set; } = null!;

    public string? RequestUrl { get; set; }

    public string? RequestMethod { get; set; }

    public string RequestBody { get; set; } = null!;

    public DateTime? RequestTimestamp { get; set; }

    public int? ResponseStatusCode { get; set; }

    public DateTime? ResponseTimestamp { get; set; }

    public string? ExceptionType { get; set; }

    public string? ExceptionMessage { get; set; }

    public string? ExceptionDetail { get; set; }
}
