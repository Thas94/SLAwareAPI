using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketStatus;
using SLAwareApi.Services.SLAware.Base;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Models.SLAware.Ticket.TicketModel;
using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware
{


    public class TicketStatusService : ClinicalServiceBase, ITicketStatusService
    {
        private readonly ISlaSeverityService _slaSeverityService;        private readonly IGlobalService _globalService;

        private readonly EntityHelper _entityHelper;

        public TicketStatusService(EntityHelper entityHelper, IGlobalService globalService, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper, ISlaSeverityService slaSeverityService) : base(context, slawareContext, mapper)
        {
            _slaSeverityService = slaSeverityService;
            _entityHelper = entityHelper;
            _globalService = globalService;
        }


        public async Task<ReturnModel> GetAllTicketStatuses()
        {
            ReturnModel Result = new ReturnModel();
            List<TicketStatusReturnModel> TicketStatusReturn = new List<TicketStatusReturnModel>();

            try
            {
                TicketStatusReturn = _slawareContext.TicketStatuses.Select(x => new TicketStatusReturnModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Active = x.Active,
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.CreatedBy,
                    UpdatedAt = x.UpdatedAt,
                    UpdatedBy = x.UpdatedBy,
                }).ToList();

                if (TicketStatusReturn != null)
                {
                    Result.Status = true;
                    Result.Result = TicketStatusReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketStatusReturn;
                    Result.error = "Internal server error.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Status Service : Get All Ticket Statuses",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;

        }

        //public async Task<ReturnModel> GetTicketStatus()
        //{
        //    ReturnModel Result = new ReturnModel();
        //    TicketStatusReturnModel TicketStatusReturn = new TicketStatusReturnModel();

        //    try
        //    {
        //        TicketStatusReturn = _slawareContext.TicketStatuses.Select(x => new TicketStatusReturnModel()
        //        {
        //            Id = x.Id,
        //            Name = x.Name,
        //            Description = x.Description,
        //            Active = x.Active,
        //            CreatedAt = x.CreatedAt,
        //            CreatedBy = x.CreatedBy,
        //            UpdatedAt = x.UpdatedAt,
        //            UpdatedBy = x.UpdatedBy,
        //        }).FirstOrDefault();

        //        if (TicketStatusReturn != null)
        //        {
        //            Result.Status = true;
        //            Result.Result = TicketStatusReturn;
        //            Result.error = null;
        //        }
        //        else
        //        {
        //            Result.Status = false;
        //            Result.Result = TicketStatusReturn;
        //            Result.error = "Internal server error.";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        //Gathering All the Error Details to be saved
        //        var Err = new ErrorTemplate
        //        {
        //            ErrCallingFunction = "Ticket Status Service : Get All Ticket Statuses",
        //            ErrErrorMessage = ex.Message.ToString(),
        //            ErrStacktrace = ex.StackTrace.ToString(),
        //        };
        //        //await _globalService.LogError(Err);
        //    }
        //    return Result;

        //}


        public async Task<ReturnModel> DeleteTicketStatus(long id)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.TicketStatuses.Where(a => a.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Status ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    
                    exists.Active = false;

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
                    ErrCallingFunction = "Ticket Status Service: Delete Status",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> CreateTicketStatus(CreateTicketStatusRequestModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;

            try
            {

                //Check to see if the site already exists
                var exists = _slawareContext.TicketStatuses.Where(s => s.Name == RequestModel.Name).FirstOrDefault();

                if (exists != null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"The status with the name :{RequestModel.Name} already exists!";
                }
                else
                {
                    //Populatinges the Site model to be inserted
                    TicketStatus NewTicketStatus = new TicketStatus()
                    {

                        Name = RequestModel.Name,
                        Description = RequestModel.Description,
                        Active = RequestModel.Active,
                        CreatedAt = DateTime.Now,
                        CreatedBy = _context.Users.Where(u => u.Id == RequestModel.loggedInUser).Select(u => u.FirstName).FirstOrDefault(),
                        UpdatedAt = DateTime.Now,
                        UpdatedBy = _context.Users.Where(u => u.Id == RequestModel.loggedInUser).Select(u => u.FirstName).FirstOrDefault()
                    };

                    _slawareContext.TicketStatuses.Add(NewTicketStatus);
                    _context.SaveChanges();

                    ticketStatusReturn = new TicketStatusReturnModel()
                    {
                        Id = NewTicketStatus.Id,
                        Name = NewTicketStatus.Name,
                        Description = NewTicketStatus.Description,
                        Active = NewTicketStatus.Active,
                      
                    };

                    Result.Status = true;
                    Result.Result = ticketStatusReturn;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                Result.Result = null;
                Result.Status = false;
                Result.error = ex.Message.ToString();

                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Status Service: Create new Ticket Status",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> UpdateTicketStatus(long id, UpdateTicketStatusRequestModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.TicketStatuses.Where(ts => ts.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Status ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    
                    // Updating Name
                    if (!string.IsNullOrWhiteSpace(RequestModel.Name))
                    {
                        exists.Name = RequestModel.Name;
                    }

                    // Updating IsActive
                    if (RequestModel.Active.HasValue)
                    {
                        exists.Active = RequestModel.Active.Value;
                    }

                    // Updating Description
                    if (!string.IsNullOrWhiteSpace(RequestModel.Description))
                    {
                        exists.Description = RequestModel.Description;
                    }


                    _slawareContext.SaveChanges();

                    ticketStatusReturn = _slawareContext.TicketStatuses.Where(x => x.Id == id).Select(x => new TicketStatusReturnModel()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Name = x.Name,
                        Active = x.Active,
                    }).FirstOrDefault();

                    Result.Status = true;
                    Result.Result = ticketStatusReturn;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Status Service: Update Ticket Status",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }




    }

}
