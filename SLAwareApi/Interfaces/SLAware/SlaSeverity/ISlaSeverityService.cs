using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface ISlaSeverityService
    {
        DateTime CalculateSlaDue(DateTime start, TimeSpan slaDuration);

    }
}
