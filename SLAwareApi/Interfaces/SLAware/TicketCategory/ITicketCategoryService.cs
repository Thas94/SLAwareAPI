using static SLAwareApi.Models.SLAware.TicketCategory.TicketCategoryModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware.TicketCategory
{
    public interface ITicketCategoryService
    {

        Task<ReturnModel> GetAllTicketCategories();

        Task<ReturnModel> GetCategory(long id);
        Task<ReturnModel> UpdateTicketCategory(long id, UpdateTicketCategoryRequestModel RequestModel);
        Task<ReturnModel> DeleteTicketCategory(long id);
        Task<ReturnModel> CreateTicketCategory(CreateTicketCategoryRequestModel RequestModel);


    }
}
