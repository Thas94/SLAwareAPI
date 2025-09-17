using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware.TicketStatus
{
    public interface ITicketStatusService
    {
        Task<ReturnModel> GetAllTicketStatuses();
        Task<ReturnModel> DeleteTicketStatus(long id);
        Task<ReturnModel> CreateTicketStatus(CreateTicketStatusRequestModel RequestModel);
        Task<ReturnModel> UpdateTicketStatus(long id, UpdateTicketStatusRequestModel RequestModel);
    }
}
