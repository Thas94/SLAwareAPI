using AutoMapper;
using Microsoft.VisualBasic;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using TFTShuttiAPI.TFTEntities.Helpers;

using SLAwareApi.Services.SLAware.Base;

namespace SLAwareApi.Services.SLAware
{
    public class SlaSeverityService : ClinicalServiceBase, ISlaSeverityService
    {
        public static readonly TimeSpan WorkStart = new TimeSpan(8, 30, 0);
        public static readonly TimeSpan WorkEnd = new TimeSpan(17, 0, 0);
        //public SlaSeverityService(slaware_dataContext slaware_DataContext) : base(slaware_DataContext)
        //{ }

        private readonly EntityHelper _entityHelper;

        public SlaSeverityService(EntityHelper entityHelper, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(context, slawareContext, mapper)
        {
            _entityHelper = entityHelper;
        }


        public DateTime CalculateSlaDue(DateTime start, TimeSpan slaDuration)
        {
            var current = start;
            var remaining = slaDuration;

            try
            {
                //check if current is outside working hours
                //if (current.TimeOfDay < WorkStart)
                //    current = current.Date.Add(WorkStart);
                //else if (current.TimeOfDay >= WorkEnd)
                //    current = current.Date.AddDays(1).Add(WorkEnd);

                while (remaining > TimeSpan.Zero)
                {
                    //check and skip if current is weekends
                    if (!IsWorkingDay(current.Date))
                    {
                        current = current.Date.AddDays(1).Add(WorkStart);
                        continue;
                    }

                    var workStartToday = current.Date.Add(WorkStart);
                    var workEndToday = current.Date.Add(WorkEnd);

                    var availableToday = workEndToday - current;
                    var timeToAdd = remaining < availableToday ? remaining : availableToday;

                    current = current.Add(timeToAdd);
                    remaining -= timeToAdd;

                    //check if there's hours remaining, move to the next day
                    if (remaining > TimeSpan.Zero)
                        current = current.Date.AddDays(1).Add(WorkStart);
                }
            }
            catch (Exception ex)
            {

            }
            return current;
        }

    }
}
