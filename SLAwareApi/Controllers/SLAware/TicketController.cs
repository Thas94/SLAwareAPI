using Microsoft.AspNetCore.Mvc;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Controllers.SLAware
{
    [Route("[controller]/[Action]")]
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
        //[HttpPost]
        //public async Task<bool> CreateTicket(CreatetTicketModel createtTicket) => await _ticketService.CreateTicket(createtTicket);
    }
}
