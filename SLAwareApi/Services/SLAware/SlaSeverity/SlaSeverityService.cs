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
                    
                    if (current > workEndToday)
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
    }
}
