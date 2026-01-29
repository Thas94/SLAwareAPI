using static SLAwareApi.Models.SLAware.TicketSubCategory.TicketSubCategoryModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware.TicketSubCategory
{
    public interface ITicketSubCategoryService
    {

        Task<ReturnModel> GetAllTicketSubCategories();
        Task<ReturnModel> GetSubCategory(long id);
        Task<ReturnModel> UpdateTicketSubCategory(long id, UpdateTicketSubCategoryReturnModel RequestModel);
        Task<ReturnModel> DeleteTicketSubCategory(long id);







    }
}
