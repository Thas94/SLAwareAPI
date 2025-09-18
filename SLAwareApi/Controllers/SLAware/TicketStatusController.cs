using Microsoft.AspNetCore.Mvc;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketStatus;
using SLAwareApi.Models.SLAware;
using SLAwareApi.Services.SLAware;
using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Controllers.SLAware
{

    [ApiController]
    [Route("api/[controller]")]
    public class TicketStatusController : ControllerBase
    {
        private readonly ITicketStatusService _ticketStatusService;
        public TicketStatusController(ITicketStatusService ticketStatusService)
        {
            _ticketStatusService = ticketStatusService; ;
        }
        
        [HttpGet]
        public async Task<ReturnModel> GetAllTicketStatuses() => await _ticketStatusService.GetAllTicketStatuses();

        [HttpPost]
        public async Task<ReturnModel> CreateTicketStatus(CreateTicketStatusRequestModel RequestModel) => await _ticketStatusService.CreateTicketStatus(RequestModel);

        [HttpPut]
        public async Task<ReturnModel> UpdateTicketStatus(long id, UpdateTicketStatusRequestModel RequestModel) => await _ticketStatusService.UpdateTicketStatus(id, RequestModel);

        [HttpDelete("{id}")]
        public async Task<ReturnModel> DeleteTicketStatus(long id) => await _ticketStatusService.DeleteTicketStatus(id);


    }
}
