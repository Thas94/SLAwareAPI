using AutoMapper;

namespace SLAwareApi.Services.SLAware.Base
{
    public class BaseService
    {
        public readonly IMapper _mapper;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
