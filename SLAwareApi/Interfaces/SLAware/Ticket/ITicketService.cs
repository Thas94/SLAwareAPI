using SLAwareApi.Models.SLAware;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface ITicketService
    {
        Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket);
        //Task<bool> CreateTicket(CreatetTicketModel createtTicket);
    }
}
