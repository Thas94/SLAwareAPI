using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Services.SLAware.Base;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware
{
    public class GlobalService : ClinicalServiceBase, IGlobalService
    {
        
        private readonly EntityHelper _entityHelper;

        public GlobalService(EntityHelper entityHelper, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(context, slawareContext, mapper)
        {
            _entityHelper = entityHelper;
        }


        public async Task<bool> LogError(ErrorTemplate TmpError)
        {
            bool Result = false;

            try
            {

                ErrorLog err = new ErrorLog()
                {
                    CallingFunction = TmpError.ErrCallingFunction,
                    ErrorMessage = TmpError.ErrErrorMessage,
                    StackTrace = TmpError.ErrStacktrace,
                    CallingScreen = TmpError.ErrCallingFunction,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin",
                    UserId = TmpError.UserID
                };

                _context.ErrorLogs.Add(err);
                _context.SaveChanges();

                Result = true;

            }
            catch (Exception ex)
            {
                Result = false;
            }
            return Result;
        }


        public async Task<T> GetCustomerSettings<T>(long CompanyID, int SettingID) where T : class
        {

            try
            {

                string ConfigurationString = _context.CompanyConfigurations.Where(cc => cc.CompanyId == CompanyID && cc.ConfigurationTypeId == SettingID).Select(cc => cc.Configuration).FirstOrDefault();

                T result = JsonConvert.DeserializeObject<T>(ConfigurationString);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}

