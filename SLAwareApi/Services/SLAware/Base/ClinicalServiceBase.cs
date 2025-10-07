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
        public static readonly TimeSpan WorkEnd = new TimeSpan(17, 0, 0);
        public static List<DateTime> PublicHolidays = new List<DateTime>
        {
            new DateTime(2025, 1, 1),   // New Year's Day
            new DateTime(2025, 3, 21),  // Human Rights Day
            new DateTime(2025, 4, 18),  // Good Friday
            new DateTime(2025, 4, 21),  // Family Day
            new DateTime(2025, 4, 27),  // Freedom Day
            new DateTime(2025, 5, 1),   // Workers' Day
            new DateTime(2025, 6, 16),  // Youth Day
            new DateTime(2025, 8, 9),   // National Women's Day
            new DateTime(2025, 9, 24),  // Heritage Day
            new DateTime(2025, 12, 16), // Day of Reconciliation
            new DateTime(2025, 12, 25), // Christmas Day
            new DateTime(2025, 12, 26)  // Day of Goodwill
        };
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

        public bool IsPublicHoliday(DateTime date)
        {
            return PublicHolidays.Contains(date) ? true : false;
        }
    }
}
