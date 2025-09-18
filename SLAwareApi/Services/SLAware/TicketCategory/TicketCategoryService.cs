using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketCategory;
using SLAwareApi.Interfaces.SLAware.TicketStatus;
using SLAwareApi.Services.SLAware.Base;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Models.SLAware.Ticket.TicketModel;
using static SLAwareApi.Models.SLAware.TicketCategory.TicketCategoryModels;
using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware.TicketCategory
{

    public class TicketCategoryService : ClinicalServiceBase, ITicketCategoryService
    {
        private readonly IGlobalService _globalService;
        private readonly EntityHelper _entityHelper;

        public TicketCategoryService(EntityHelper entityHelper, IGlobalService globalService, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(context, slawareContext, mapper)
        {
            _entityHelper = entityHelper;
            _globalService = globalService;
        }


        public async Task<ReturnModel> GetAllTicketCategories()
        {

            ReturnModel Result = new ReturnModel();
            List<TicketCategoryReturnModel> TicketCategoryReturn = new List<TicketCategoryReturnModel>();

            try
            {
                TicketCategoryReturn = _slawareContext.TicketCategories.Select(x => new TicketCategoryReturnModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsActive = x.IsActive,
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.CreatedBy,
                    UpdatedAt = x.UpdatedAt,
                    UpdatedBy = x.UpdatedBy,

                }).ToList();

                if (TicketCategoryReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = TicketCategoryReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketCategoryReturn;
                    Result.error = "Internal server error.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get All Tickets",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> GetCategory(long id)
        {
            ReturnModel Result = new ReturnModel();
            TicketCategoryReturnModel ticketCategoryReturn = new TicketCategoryReturnModel();

            try
            {
                ticketCategoryReturn = _slawareContext.TicketCategories.Where(x => x.Id == id)
                    .Select(x => new TicketCategoryReturnModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        IsActive = x.IsActive,
                        CreatedAt = x.CreatedAt,
                        CreatedBy = x.CreatedBy,
                        UpdatedAt = x.UpdatedAt,
                        UpdatedBy = x.UpdatedBy,
                    }).FirstOrDefault();

                if (ticketCategoryReturn != null)
                {
                    Result.Status = true;
                    Result.Result = ticketCategoryReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = ticketCategoryReturn;
                    Result.error = $"Category details for id: {id} not found";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Category Service : Get Ticket Category",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;

        }


        public async Task<ReturnModel> UpdateTicketCategory(long id, UpdateTicketCategoryRequestModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketCategoryReturnModel ticketCategoryReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.Tickets.Where(ts => ts.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketCategoryReturn;
                    Result.error = $"Category ID does not exist!";
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

                    ticketCategoryReturn = _slawareContext.TicketCategories.Where(x => x.Id == id).Select(x => new TicketCategoryReturnModel()
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
                    Result.Result = ticketCategoryReturn;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Category Service: Update Ticket Category",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> DeleteTicketCategory(long id)
        {

            ReturnModel Result = new ReturnModel();
            TicketCategoryReturnModel ticketStatusReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.TicketCategories.Where(a => a.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Ticket Category ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    


                    //_slawareContext.Tickets.Remove(exists);  // mark entity for deletion
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
                    ErrCallingFunction = "Ticket Category Service: Delete Category",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }

        //public async Task<ReturnModel> CreateTicket(CreateTicketCategoryModel RequestModel)
        //{

        //    ReturnModel Result = new ReturnModel();
        //    TicketCategoryReturnModel ticketReturn = null;

        //    try
        //    {
        //        var priority = _slawareContext.SubCategorySeverityLevels.Where(sc => sc.SubCategoryId == RequestModel.SubCategoryId).Select(sc => sc.SlaSeverityLevelId).FirstOrDefault();

        //        TicketCategory NewTicket = new Ticket()
        //        {
        //            TicketNumber = ticketNumber,
        //            Subject = RequestModel.Subject,
        //            Description = RequestModel.Description,
        //            TicketStatusId = RequestModel.TicketStatusId,
        //            SeverityLevelId = priority,
        //            CreatedById = RequestModel.CreatedById,
        //            CategoryId = RequestModel.CategoryId,
        //            SubCategoryId = RequestModel.SubCategoryId,
        //            CreatedAt = DateTime.Now,
        //            IsActive = true
        //        };

        //        _slawareContext.Tickets.Add(NewTicket);
        //        _slawareContext.SaveChanges();

        //        //// Generate ticket number
        //        //NewTicket.TicketNumber = $"TCK-{DateTime.Now.Year}-{NewTicket.Id:D6}";
        //        //_slawareContext.Tickets.Update(NewTicket);
        //        //await _slawareContext.SaveChangesAsync();


        //        //TicketSlaTracking ticketSlaTracking = new TicketSlaTracking();
        //        //{

        //        //    TicketId = 
        //        //};


        //        ticketReturn = new TicketReturnModel()
        //        {
        //            Id = NewTicket.Id,
        //            Subject = NewTicket.Subject,
        //            Description = NewTicket.Description,
        //            SeverityLevelId = NewTicket.SeverityLevelId,
        //            TicketStatusId = NewTicket.TicketStatusId,
        //            SubCategoryId = NewTicket.SubCategoryId,
        //            CreatedById = NewTicket.CreatedById,
        //            IsActive = NewTicket.IsActive,
        //        };

        //        Result.Status = true;
        //        Result.Result = NewTicket;
        //        Result.error = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        Result.Result = null;
        //        Result.Status = false;
        //        Result.error = ex.Message.ToString();

        //        //Gathering All the Error Details to be saved
        //        var Err = new ErrorTemplate
        //        {
        //            ErrCallingFunction = "Ticket Service: Create Ticket",
        //            ErrErrorMessage = ex.Message.ToString(),
        //            ErrStacktrace = ex.StackTrace.ToString(),
        //        };
        //        await _globalService.LogError(Err);
        //    }
        //    return Result;

        //}


    }
}


