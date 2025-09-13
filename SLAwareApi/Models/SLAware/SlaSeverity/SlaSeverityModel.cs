namespace SLAwareApi.Models.SLAware
{
    public class SlaSeverityModel
    {
        public long Id { get; set; }
        public string SeverityLevels { get; set; }
        public long InitialResponseHours { get; set; }
        public long TargetResolutionHours { get; set; }
    }
}
