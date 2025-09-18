using AutoMapper;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;

namespace SLAwareApi.Services.SLAware.Base
{
    public class ClinicalServiceBase : BaseService
    {
        public readonly TftAppContext _context;
        public readonly slaware_dataContext _slawareContext;
        public static readonly TimeSpan WorkStart = new TimeSpan(8, 30, 0);
        public static readonly TimeSpan WorkEnd = new TimeSpan(22, 10, 0);
        public ClinicalServiceBase(TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(mapper)
        {
            _context = context;
            context.ChangeTracker.AutoDetectChangesEnabled = true;

            _slawareContext = slawareContext;
            slawareContext.ChangeTracker.AutoDetectChangesEnabled = true;
        }
        public bool IsWorkingDay(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday ? true : false;
        }
        public bool IsWorkingHours(DateTime date)
        {
            return date.TimeOfDay >= WorkStart && date.TimeOfDay <= WorkEnd ? true : false;
        }
    }
}
