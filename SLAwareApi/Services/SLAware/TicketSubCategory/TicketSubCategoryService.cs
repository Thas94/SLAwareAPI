using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketCategory;
using SLAwareApi.Interfaces.SLAware.TicketSubCategory;
using SLAwareApi.Services.SLAware.Base;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Models.SLAware.TicketCategory.TicketCategoryModels;
using static SLAwareApi.Models.SLAware.TicketSubCategory.TicketSubCategoryModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware.TicketSubCategory
{

    public class TicketSubCategoryService : ClinicalServiceBase, ITicketSubCategoryService
    {
        private readonly IGlobalService _globalService;
        private readonly EntityHelper _entityHelper;

        public TicketSubCategoryService(EntityHelper entityHelper, IGlobalService globalService, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(context, slawareContext, mapper)
        {
            _entityHelper = entityHelper;
            _globalService = globalService;
        }



        public async Task<ReturnModel> GetAllTicketSubCategories()
        {

            ReturnModel Result = new ReturnModel();
            List<TicketSubCategoryReturnModel> ticketSubCategoryReturn = new List<TicketSubCategoryReturnModel>();

            try
            {

                ticketSubCategoryReturn = _slawareContext.TicketSubCategories.Select(x => new TicketSubCategoryReturnModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    TicketCategoryId = x.TicketCategoryId,
                    IsActive = x.IsActive,
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.CreatedBy,
                    UpdatedAt = x.UpdatedAt,
                    UpdatedBy = x.UpdatedBy,

                }).ToList();

                if (ticketSubCategoryReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = "Internal server error.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Sub Category Service : Get All SubCategories",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> GetSubCategory(long id)
        {
            ReturnModel Result = new ReturnModel();
            TicketSubCategoryReturnModel ticketSubCategoryReturn = new TicketSubCategoryReturnModel();

            try
            {
                ticketSubCategoryReturn = _slawareContext.TicketSubCategories.Where(x => x.Id == id)
                    .Select(x => new TicketSubCategoryReturnModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        IsActive = x.IsActive,
                        TicketCategoryId = x.TicketCategoryId,
                        CreatedAt = x.CreatedAt,
                        CreatedBy = x.CreatedBy,
                        UpdatedAt = x.UpdatedAt,
                        UpdatedBy = x.UpdatedBy,
                    }).FirstOrDefault();

                if (ticketSubCategoryReturn != null)
                {
                    Result.Status = true;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = $"SubCategory details for id: {id} not found";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket SubCategory Service : Get Ticket Sub Category",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;

        }


        public async Task<ReturnModel> UpdateTicketSubCategory(long id, UpdateTicketSubCategoryReturnModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketSubCategoryReturnModel ticketSubCategoryReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.TicketSubCategories.Where(ts => ts.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = $"Sub Category ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    
                    // Updating Name
                    //if (!string.IsNullOrWhiteSpace(RequestModel))
                    //{
                    //    exists.Name = RequestModel.Name;
                    //}

                    //// Updating IsActive
                    //if (RequestModel.Active.HasValue)
                    //{
                    //    exists.Active = RequestModel.Active.Value;
                    //}

                    //// Updating Description
                    //if (!string.IsNullOrWhiteSpace(RequestModel.Description))
                    //{
                    //    exists.Description = RequestModel.Description;
                    //}


                    _slawareContext.SaveChanges();

                    ticketSubCategoryReturn = _slawareContext.TicketSubCategories.Where(x => x.Id == id).Select(x => new TicketSubCategoryReturnModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        IsActive = x.IsActive,
                        CreatedAt = x.CreatedAt,
                        CreatedBy = x.CreatedBy,
                        UpdatedAt = x.UpdatedAt,
                        UpdatedBy = x.UpdatedBy,
                    }).FirstOrDefault();

                    Result.Status = true;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Sub Category Service: Update Ticket Category",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> DeleteTicketSubCategory(long id)
        {

            ReturnModel Result = new ReturnModel();
            TicketSubCategoryReturnModel ticketSubCategoryReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.TicketSubCategories.Where(a => a.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketSubCategoryReturn;
                    Result.error = $"Ticket Sub Category ID does not exist!";
                }
                else
                {

                    exists.IsActive = false;

                    _slawareContext.SaveChanges();

                    Result.Status = true;
                    Result.Result = null;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Sub Category Service: Delete Sub Category",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }


    }
}
