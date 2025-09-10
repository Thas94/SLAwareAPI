using SLAwareApi.Entities.SLAware;

namespace SLAwareApi.Services.SLAware
{
    public class SLAwareBaseService
    {
        public readonly slaware_dataContext _slaware_DataContext;

        public SLAwareBaseService(slaware_dataContext slaware_DataContext)
        {
            _slaware_DataContext = slaware_DataContext;
        }
    }
}
