using SLAwareApi.Models.SLAware;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface ITicketService
    {
        Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket);
        Task<ReturnModel> GetTicket(long id, long userId);
        Task<ReturnModel> GetAssignedTickets( long userId);
        Task<ReturnModel> DeleteTicket(long id);

        //Task<bool> CreateTicket(CreatetTicketModel createtTicket);
    }
}
