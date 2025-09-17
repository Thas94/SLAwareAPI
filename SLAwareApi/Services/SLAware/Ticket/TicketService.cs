using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using SLAwareApi.Services.SLAware.Base;
using System.Net.Sockets;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Models.SLAware.Ticket.TicketModel;
using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware
{
    public class TicketService : ClinicalServiceBase, ITicketService
    {
        private readonly ISlaSeverityService _slaSeverityService;
        private readonly EntityHelper _entityHelper;
        private readonly IGlobalService _globalService;


        public TicketService(EntityHelper entityHelper, TftAppContext context, IGlobalService globalService, slaware_dataContext slawareContext, IMapper mapper, ISlaSeverityService slaSeverityService) : base(context, slawareContext, mapper)
        {
            _slaSeverityService = slaSeverityService;
            _entityHelper = entityHelper;
            _globalService = globalService;

        }

        public async Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket)
        {

            ReturnModel Result = new ReturnModel();



            try
            {
                //Create ticket
                var ticketModel = new Ticket();
                ticketModel.Subject = createtTicket.Subject;
                ticketModel.Description = createtTicket.Description;
                ticketModel.TicketStatusId = createtTicket.TicketStatusId;
                ticketModel.TicketSeverityLevelId = createtTicket.TicketSeverityLevelId;
                ticketModel.CreatedById = createtTicket.CreateById;
                ticketModel.CreatedAt = DateTime.Now;
                ticketModel.SubCategoryId = createtTicket.SubCategorylId;
                _slawareContext.Tickets.Add(ticketModel);
                //_slaware_DataContext.SaveChanges();

                //Create message
                var messageModel = new TicketMessage();
                messageModel.TicketId = ticketModel.Id;
                messageModel.MessageContent = createtTicket.Message;
                messageModel.CreatedAt = DateTime.Now;
                _slawareContext.TicketMessages.Add(messageModel);
                //_slaware_DataContext.SaveChanges();

                //SLA tracking
                foreach (var sev in createtTicket.SlaSeverities)
                {
                    var track = new TicketSlaTracking();
                    track.TicketId = ticketModel.Id;
                    track.SlaSeverityLevelId = sev.Id;
                    track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)sev.InitialResponseHours, 0, 0));
                    track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)sev.TargetResolutionHours, 0, 0));
                    track.CreatedAt = DateTime.Now;
                    _slawareContext.TicketSlaTrackings.Add(track);
                    //_slaware_DataContext.SaveChanges();
                }


                if (ticketModel != null)
                {
                    Result.Status = true;
                    Result.Result = ticketModel;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = null;
                    Result.error = "Internal server error.";
                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service: Get Ticket List",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);

            }
            return Result;
        }


        public async Task<ReturnModel> GetTicket(long id, long userId)
        {
            ReturnModel Result = new ReturnModel();
            TicketReturnModel TicketReturn = new TicketReturnModel();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(x => x.CreatedById == userId && x.Id == id)
                    .Select(x => new TicketReturnModel()
                {
                    Id = x.Id,
                    TicketNumber = x.TicketNumber,
                    Description = x.Description,
                    Subject = x.Subject,
                    TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(tn => tn.Name).FirstOrDefault(),
                    TicketSeverityLevelId = x.TicketSeverityLevelId,
                    CreatedById = x.CreatedById,   
                    AssignedToId = x.AssignedToId,
                    SubCategoryId = x.SubCategoryId,
                    CreatedAt = x.CreatedAt
                }).FirstOrDefault();

                if (TicketReturn != null)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
                    Result.error = "Internal server error.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get Ticket",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;

        }


        public async Task<ReturnModel> GetAllTickets()
        {
            ReturnModel Result = new ReturnModel();
            List<TicketReturnModel> TicketReturn = new List<TicketReturnModel>();

            try
            {
                TicketReturn = _slawareContext.Tickets.Select(x => new TicketReturnModel()
                {
                    Id = x.Id,
                    TicketNumber = x.TicketNumber,
                    Description = x.Description,
                    Subject = x.Subject,
                    //TicketStatus = _slawareContext.TicketStatuses.Where(x.)


                }).ToList();

                if (TicketReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
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

        public async Task<ReturnModel> GetAssignedTickets(long userId)
        {
            ReturnModel Result = new ReturnModel();
            List<TicketReturnModel> TicketReturn = new List<TicketReturnModel>();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(t => t.AssignedToId == userId)
                    .Select(x => new TicketReturnModel()
                {
                    Id = x.Id,
                    TicketNumber = x.TicketNumber,
                    Description = x.Description,
                    Subject = x.Subject,
                    //TicketStatus = x.TicketStatusId,
                    TicketSeverityLevelId = x.TicketSeverityLevelId,    
                    CreatedById = x.CreatedById,
                    AssignedToId = x.AssignedToId,
                    SubCategoryId = x.SubCategoryId,
                    CreatedAt = x.CreatedAt,


                }).ToList();

                if (TicketReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
                    Result.error = "No Tickets found.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get Assigned Tickets",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> DeleteTicket(long id)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;
            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.Tickets.Where(a => a.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Ticket ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    


                    _slawareContext.Tickets.Remove(exists);  // mark entity for deletion
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
