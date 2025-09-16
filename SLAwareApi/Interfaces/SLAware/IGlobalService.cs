using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface IGlobalService
    {
        public Task<bool> LogError(ErrorTemplate TmpError);

        Task<T> GetCustomerSettings<T>(long CompanyID, int SettingID) where T : class;
    }
}
