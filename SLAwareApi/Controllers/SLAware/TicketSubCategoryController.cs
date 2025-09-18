using Microsoft.AspNetCore.Mvc;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketSubCategory;
using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.SLAware.TicketSubCategory.TicketSubCategoryModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Controllers.SLAware
{

    [Route("api/[controller]")]
    [ApiController]
    public class TicketSubCategoryController : ControllerBase
    {
        private readonly ITicketSubCategoryService _ticketSubCategoryService;
        public TicketSubCategoryController(ITicketSubCategoryService ticketSubCategoryService)
        {
            _ticketSubCategoryService = ticketSubCategoryService;
        }


        [HttpGet("allSubCategories")]
        public async Task<ReturnModel> GetAllTicketSubCategories() => await _ticketSubCategoryService.GetAllTicketSubCategories();

     
        [HttpGet]
        public async Task<ReturnModel> GetSubCategory(long id) => await _ticketSubCategoryService.GetSubCategory(id);

     
        [HttpPut]
        public async Task<ReturnModel> UpdateTicketSubCategory(long id, UpdateTicketSubCategoryReturnModel RequestModel) => await _ticketSubCategoryService.UpdateTicketSubCategory(id, RequestModel);

        [HttpDelete("{id}")]
        public async Task<ReturnModel> DeleteTicketSubCategory(long id) => await _ticketSubCategoryService.DeleteTicketSubCategory(id);




    }
}
