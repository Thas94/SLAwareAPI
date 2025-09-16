using Microsoft.VisualBasic;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;

namespace SLAwareApi.Services.SLAware
{
    public class SlaSeverityService : SLAwareBaseService, ISlaSeverityService
    {
        public static readonly TimeSpan WorkStart = new TimeSpan(8, 30, 0);
        public static readonly TimeSpan WorkEnd = new TimeSpan(17, 0, 0);
        public SlaSeverityService(slaware_dataContext slaware_DataContext) : base(slaware_DataContext)
        { }

        public DateTime CalculateSlaDue(DateTime start, TimeSpan slaDuration)
        {
            var current = start;
            var remaining = slaDuration;

            try 
            {
                while (remaining > TimeSpan.Zero)
                {
                    if (!IsWorkingDay(current.Date))
                    {
                        current = current.Date.AddDays(1).Add(WorkStart);
                        continue;
                    }

                    var workStartToday = current.Date.Add(WorkStart);
                    var workEndToday = current.Date.Add(WorkEnd);

                    if (current < workStartToday)
                        current = workStartToday;

                    var availableToday = workEndToday - current;
                    var timeToAdd = remaining < availableToday ? remaining : availableToday;

                    current = current.Add(timeToAdd);
                    remaining -= timeToAdd;

                    if (remaining > TimeSpan.Zero)
                        current = current.Date.AddDays(1).Add(WorkStart);
                }
            }
            catch (Exception ex)
            {

            }
            return current;
        }

        private bool IsWorkingDay(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday ? true : false;
        }
    }
}
