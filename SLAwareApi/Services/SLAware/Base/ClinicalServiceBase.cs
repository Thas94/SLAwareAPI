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
        public ClinicalServiceBase(TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(mapper)
        {
            _context = context;
            context.ChangeTracker.AutoDetectChangesEnabled = true;

            _slawareContext = slawareContext;
            slawareContext.ChangeTracker.AutoDetectChangesEnabled = true;
        }
    }
}
