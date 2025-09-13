using SLAwareApi.Models.SLAware;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface ITicketService
    {
        Task<bool> CreateTicket(CreatetTicketModel createtTicket);
    }
}
