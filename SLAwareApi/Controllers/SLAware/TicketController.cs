using Microsoft.AspNetCore.Mvc;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Controllers.SLAware
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket) => await _ticketService.CreateTicket(createtTicket);
        [HttpPost]
        public async Task<ReturnModel> UpdateTicket(CreatetTicketModel RequestModel) => await _ticketService.UpdateTicket(RequestModel);

        [HttpGet("{id}")]
        public async Task<ReturnModel> GetTicket(long id, long userId) => await _ticketService.GetTicket(id, userId);

        [HttpDelete("{id}")]
        public async Task<ReturnModel> DeleteTicket(long id, long userId) => await _ticketService.DeleteTicket(id);
       
        [HttpGet("allTickets")]
        public async Task<ReturnModel> GetAllTicket(long id, long userId) => await _ticketService.GetTicket(id, userId);
        
        [HttpGet("assignedTickets{id}")]
        public async Task<ReturnModel> GetAssignedTickets( long userId) => await _ticketService.GetAssignedTickets( userId);
        //[HttpPost]
        //public async Task<bool> CreateTicket(CreatetTicketModel createtTicket) => await _ticketService.CreateTicket(createtTicket);
    }
}
