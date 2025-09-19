using Microsoft.AspNetCore.Mvc;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketCategory;
using SLAwareApi.Services.SLAware;
using SLAwareApi.Services.SLAware;
using static SLAwareApi.Models.SLAware.TicketCategory.TicketCategoryModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Controllers.SLAware
{

    [Route("api/[controller]")]
    [ApiController]
    public class TicketCategoryController : ControllerBase
    {
        private readonly ITicketCategoryService _ticketCategory;
        public TicketCategoryController(ITicketCategoryService ticketCategory)
        {
            _ticketCategory = ticketCategory;
        }

        [HttpGet("allCategories")]
        public async Task<ReturnModel> GetTicketCategories() => await _ticketCategory.GetAllTicketCategories();

        [HttpGet]
        public async Task<ReturnModel> GetCategory(long id) => await _ticketCategory.GetCategory(id);
        
        [HttpPost]
        public async Task<ReturnModel> CreateTicketCategory(CreateTicketCategoryRequestModel RequestModel) => await _ticketCategory.CreateTicketCategory(RequestModel);
        //[HttpPut("{id}")]
        //public async Task<ReturnModel> UpdateTicketCategory(long id, UpdateTicketCategoryRequestModel RequestModel) => await _ticketCategory.UpdateTicketCategory(id, RequestModel);

        [HttpDelete("{id}")]
        public async Task<ReturnModel> DeleteCategory(long id ) => await _ticketCategory.DeleteTicketCategory(id);

    }
}
