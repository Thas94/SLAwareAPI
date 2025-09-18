using SLAwareApi.Models.SLAware;
using static SLAwareApi.Models.SLAware.Ticket.TicketModel;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface ITicketService
    {
        //Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket);
        Task<ReturnModel> CreateTicket(CreateTicketModel createtTicket);
        Task<ReturnModel> GetTicket(long id);
        Task<ReturnModel> GetAssignedTickets(long userId);
        Task<ReturnModel> GetClientTickets(long userId);
        Task<ReturnModel> DeleteTicket(long id);
        Task<ReturnModel> GetAllTickets();
        Task<ReturnModel> AssignTicketToAgent(long ticketId, long userId);
        Task<ReturnModel> UpdateTicket(long id, UpdateTicketRequestModel RequestModel);

        //Task<bool> CreateTicket(CreatetTicketModel createtTicket);
    }
}
