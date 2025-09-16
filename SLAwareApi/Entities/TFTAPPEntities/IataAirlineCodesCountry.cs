using System;
using System.Collections.Generic;

namespace SLAwareApi.Entities.TFTAPPEntities;

public partial class IataAirlineCodesCountry
{
    public string? IataCode { get; set; }

    public string? AirportName { get; set; }

    public string? Location { get; set; }

    public string? Country { get; set; }
}
