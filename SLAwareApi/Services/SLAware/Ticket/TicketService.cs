using AutoMapper;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using SLAwareApi.Models.SLAware.Ticket;
using SLAwareApi.Services.SLAware.Base;
using System;
using System.Net.Sockets;
using System.Text.Json;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Enums.Enums;
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

        public async Task<ReturnModel> GetTicket(long id)
        {
            ReturnModel Result = new ReturnModel();
            TicketReturnModel TicketReturn = new TicketReturnModel();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(x => x.Id == id)
                    .Select(x => new TicketReturnModel()
                    {
                        Id = x.Id,
                        TicketNumber = x.TicketNumber,
                        Description = x.Description,
                        Subject = x.Subject,
                        TicketStatusId = x.TicketStatusId,
                        SeverityLevelId = x.SeverityLevelId,
                        CreatedById = x.CreatedById,
                        AssignedToId = x.AssignedToId,
                        SubCategoryId = x.SubCategoryId,
                        CategoryId = x.CategoryId,
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
                    Result.error = $"Ticket details for id: {id} not found";
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
                    TicketStatusId = x.TicketStatusId,
                    //TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(tn => tn.Name).FirstOrDefault(),
                    SeverityLevelId = x.SeverityLevelId,
                    CreatedById = x.CreatedById,
                    AssignedToId = x.AssignedToId,
                    SubCategoryId = x.SubCategoryId,
                    CategoryId = x.CategoryId,
                    CreatedAt = x.CreatedAt
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

        public async Task<ReturnModel> GetClientTickets(long userId)
        {
            ReturnModel Result = new ReturnModel();
            List<TicketReturnModel> TicketReturn = new List<TicketReturnModel>();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(t => t.CreatedById == userId)
                    .Select(x => new TicketReturnModel()
                    {
                        Id = x.Id,
                        TicketNumber = x.TicketNumber,
                        Subject = x.Subject,
                        Description = x.Description,
                        TicketStatusId = x.TicketStatusId,
                        SeverityLevelId = x.SeverityLevelId,
                        CreatedById = x.CreatedById,
                        AssignedToId = x.AssignedToId,
                        CategoryId = x.CategoryId,
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
                    ErrCallingFunction = "Ticket Service : Get Client Tickets",
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
                TicketReturn = (from ticket in _slawareContext.Tickets
                                join status in _slawareContext.TicketStatuses on ticket.TicketStatusId equals status.Id
                                join category in _slawareContext.TicketCategories on ticket.CategoryId equals category.Id
                                join sub_category in _slawareContext.TicketSubCategories on ticket.SubCategoryId equals sub_category.Id
                                join severity in _slawareContext.SlaSeverityLevels on ticket.SeverityLevelId equals severity.Id
                                join severity_rules in _slawareContext.SlaSeverityLevelRules on ticket.SeverityLevelId equals severity_rules.SlaSeverityLevelId
                                join sla in _slawareContext.TicketSlaTrackings on ticket.Id equals sla.TicketId
                                let messages = _slawareContext.TicketMessages.Where(x => x.TicketId == ticket.Id).Select(x => x.MessageContent).ToList()
                                let activityLogs = _slawareContext.TicketActivityLogs.Where(x => x.TicketId == ticket.Id).Select(x => new TicketActivity { Created_At = x.CreatedAt, Description = x.Description}).ToList()
                                where status.Active && category.IsActive && sub_category.IsActive && ticket.AssignedToId == userId
                                select new TicketReturnModel
                                {
                                    Id = ticket.Id,
                                    TicketNumber = ticket.TicketNumber,
                                    Description = ticket.Description,
                                    Subject = ticket.Subject,
                                    SeverityLevel = $"{severity.Severity} - {severity.Name}",
                                    TicketStatus = status.Name,
                                    Category = category.Name,
                                    SubCategory = sub_category.Name,
                                    CreatedAt = ticket.CreatedAt,
                                    InitialResponseDue = sla.ResponseDueDtm,
                                    TargetResolutionDue = sla.ResolutionDueDtm,
                                    IsSlaResponseBreach = sla.IsResponseSlaBreach,
                                    IsSlaResolutionBreach = sla.IsResolutionSlaBreach,
                                    RemainingResponseTime = sla.RemainingResponseDueTime,
                                    RemainingResolutionTime = sla.RemainingResolutionDueTime,
                                    Messages = messages,
                                    TicketActivities = activityLogs,
                                    ResolutionHours = severity_rules.TargetResolutionHours,
                                    ResponseHours = severity_rules.InitialResponseHours,
                                    Response_PauseAt = sla.ResponsePausedDtm,
                                    Resolution_PauseAt = sla.ResolutionPausedDtm,
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
                    ErrCallingFunction = "Ticket Status Service: Delete Status",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }

        public async Task<ReturnModel> CreateTicket(CreateTicketModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketReturnModel ticketReturn = null;

            try
            {
                var priority = _slawareContext.SubCategorySeverityLevels.Where(sc => sc.SubCategoryId == RequestModel.SubCategoryId).Select(sc => sc.SlaSeverityLevelId).FirstOrDefault();
                var sla_rule = _slawareContext.SlaSeverityLevelRules.FirstOrDefault(x => x.SlaSeverityLevelId == priority);
                //Populating the Ticket model to be inserted

                var random = new Random();
                var ticketNumber = $"TCK-{DateTime.Now.Year}-{random.Next(100000, 999999)}";

                Ticket NewTicket = new Ticket()
                {
                    TicketNumber = ticketNumber,
                    Subject = RequestModel.Subject,
                    Description = RequestModel.Description,
                    TicketStatusId = RequestModel.TicketStatusId,
                    SeverityLevelId = priority,
                    CreatedById = RequestModel.CreatedById,
                    CategoryId = RequestModel.CategoryId,
                    SubCategoryId = RequestModel.SubCategoryId,
                    CreatedAt = DateTime.Now,
                    IsActive = true
                };

                _slawareContext.Tickets.Add(NewTicket);
                _slawareContext.SaveChanges();

                //SLA tracking
                var track = new TicketSlaTracking();
                track.TicketId = NewTicket.Id;
                track.SlaSeverityLevelId = priority;
                track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(NewTicket.CreatedAt, new TimeSpan((int)sla_rule.InitialResponseHours, 0, 0));
                track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(NewTicket.CreatedAt, new TimeSpan((int)sla_rule.TargetResolutionHours, 0, 0));
                //track.RemainingResponseDueTime = !IsWorkingDay(NewTicket.CreatedAt.Date) || !IsWorkingHours(NewTicket.CreatedAt) ? TimeOnly.FromTimeSpan(new TimeSpan((int)sla_rule.InitialResponseHours, 0, 0)) : null;
                //track.RemainingResolutionDueTime = !IsWorkingDay(NewTicket.CreatedAt.Date) || !IsWorkingHours(NewTicket.CreatedAt) ? TimeOnly.FromTimeSpan(new TimeSpan((int)sla_rule.TargetResolutionHours, 0, 0)) : null;
                track.CreatedAt = DateTime.Now;
                track.IsResponseSlaBreach = false;
                track.IsResolutionSlaBreach = false;
                _slawareContext.TicketSlaTrackings.Add(track);
                _slawareContext.SaveChanges();

                //Ticket activity
                var activity = new TicketActivityLog();
                activity.UserId = NewTicket.CreatedById;
                activity.TicketId = NewTicket.Id;
                activity.Description = "Ticket created.";
                activity.CreatedAt = NewTicket.CreatedAt;
                var user = _context.Users.FirstOrDefault(x => x.Id == NewTicket.CreatedById);
                activity.CreatedBy = $"{user.FirstName} {user.LastName}";
                activity.NewTicketStatusId = (int)Enums.Enums.TicketStatus.New;
                _slawareContext.TicketActivityLogs.Add(activity);
                _slawareContext.SaveChanges();


                ticketReturn = new TicketReturnModel()
                {
                    Id = NewTicket.Id,
                    Subject = NewTicket.Subject,
                    Description = NewTicket.Description,
                    SeverityLevelId = NewTicket.SeverityLevelId,
                    TicketStatusId = NewTicket.TicketStatusId,
                    SubCategoryId = NewTicket.SubCategoryId,
                    CreatedById = NewTicket.CreatedById,
                    IsActive = NewTicket.IsActive,
                };

                Result.Status = true;
                Result.Result = NewTicket;
                Result.error = null;
            }
            catch (Exception ex)
            {
                Result.Result = null;
                Result.Status = false;
                Result.error = ex.Message.ToString();

                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service: Create Ticket",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;

        }

        public async Task<ReturnModel> AssignTicketToAgent(long ticketId, long userId)
        {
            ReturnModel Result = new ReturnModel();
            TicketReturnModel ticketReturn = null;

            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    Result.Status = false;
                    Result.Result = null;
                    Result.error = $"User ID {userId} does not exist!";
                    return Result;
                }

                var ticket = _slawareContext.Tickets.FirstOrDefault(t => t.Id == ticketId);
                if (ticket == null)
                {
                    Result.Status = false;
                    Result.Result = null;
                    Result.error = $"Ticket ID {ticketId} does not exist!";
                    return Result;
                }

                // Assign
                ticket.AssignedToId = userId;
                await _slawareContext.SaveChangesAsync();

                // Return updated ticket
                ticketReturn = _slawareContext.Tickets
                    .Where(x => x.Id == ticketId)
                    .Select(x => new TicketReturnModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Subject = x.Subject,
                        CategoryId = x.CategoryId,
                        SubCategoryId = x.SubCategoryId,
                        AssignedToId = x.AssignedToId,
                        IsActive = x.IsActive,
                    })
                    .FirstOrDefault();

                Result.Status = true;
                Result.Result = ticketReturn;
                Result.error = null;
            }
            catch (Exception ex)
            {
                Result.Status = false;
                Result.Result = null;
                Result.error = ex.Message;
            }

            return Result;
        }

        public async Task<ReturnModel> UpdateTicket(UpdateTicketRequestModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;

            try
            {
                var ticket = _slawareContext.Tickets.FirstOrDefault(x => x.Id == RequestModel.TicketId);
                //Check to see if the application already exists

                if (ticket == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Ticket ID does not exist!";
                }
                else
                {
                    //Ticket
                    ticket.TicketStatusId = _slawareContext.TicketStatuses.FirstOrDefault(x => x.Name == RequestModel.Status).Id;


                    //SLA Tracking
                    var sla = _slawareContext.TicketSlaTrackings.FirstOrDefault(x => x.TicketId == ticket.Id);

                    if (!sla.FirstResponseAt.HasValue)
                    {
                        sla.FirstResponseAt = DateTime.Now;
                    }
                    _slawareContext.SaveChanges();

                    //Message
                    if (!string.IsNullOrEmpty(RequestModel.Message))
                    {
                        var model = new TicketMessage();
                        model.TicketId = ticket.Id;
                        model.CreatedAt = DateTime.Now;
                        model.MessageContent = RequestModel.Message;
                        _slawareContext.TicketMessages.Add(model);
                       _slawareContext.SaveChanges();
                    }

                    //Activity
                    if(_slawareContext.TicketActivityLogs.OrderBy(x => x.Id).LastOrDefault(x => x.TicketId == RequestModel.TicketId) is { } log)
                    {
                        var act = new TicketActivityLog();
                        var statuses = _slawareContext.TicketStatuses.Where(x => x.Active).ToList();
                        var user = _context.Users.FirstOrDefault(x => x.Id == RequestModel.UserId);
                        var oldSt = log.NewTicketStatusId;
                        var newSt = ticket.TicketStatusId;
                        act.NewTicketStatusId = newSt;
                        act.OldTicketStatusId = oldSt;
                        act.Description = $"Ticket status changed from {statuses.FirstOrDefault(x => x.Id == oldSt).Name} to {statuses.FirstOrDefault(x => x.Id == newSt).Name}";
                        act.CreatedAt = DateTime.Now;
                        act.CreatedBy = $"{user.FirstName} {user.LastName}";
                        act.UserId = RequestModel.UserId;
                        act.TicketId = log.TicketId;
                        _slawareContext.TicketActivityLogs.Add(act);
                        //_slawareContext.SaveChanges();
                    }

                    OnTicketStatusChanged(ticket.Id, ticket.TicketStatusId);


                    Result.Status = true;
                    Result.Result = null;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                Result.Status = false;
                Result.Result = null;
                Result.error = ex.Message.ToString();
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

        private void OnTicketStatusChanged(long ticketId, long ticketStatusId)
        {
            if (ticketStatusId == (int)Enums.Enums.TicketStatus.AwaitingFeedback)
            {
                TicketPause(ticketId);
            }
            else
            {
                TicketResume(ticketId);
            }
        }

        private void TicketPause(long ticketId)
        {
            var ticket = _slawareContext.TicketSlaTrackings.FirstOrDefault(x => x.TicketId == ticketId);

            if (!ticket.ResponsePausedDtm.HasValue)
            {
                if (!ticket.IsResponseSlaBreach.Value && DateTime.Now <= ticket.ResponseDueDtm)
                {
                    ticket.ResponsePausedDtm = DateTime.Now;
                    ticket.RemainingResponseDueTime = TimeOnly.FromTimeSpan(ticket.ResponseDueDtm - DateTime.Now);
                }
            }

            if(!ticket.ResolutionPausedDtm.HasValue)
            {
                if (!ticket.IsResolutionSlaBreach.Value && DateTime.Now <= ticket.ResolutionDueDtm)
                {
                    ticket.ResolutionPausedDtm = DateTime.Now;
                    ticket.RemainingResolutionDueTime = TimeOnly.FromTimeSpan(ticket.ResolutionDueDtm - DateTime.Now);
                }
            }
            _slawareContext.SaveChanges();
        }

        private void TicketResume(long ticketId)
        {
            var ticket = _slawareContext.TicketSlaTrackings.FirstOrDefault(x => x.TicketId == ticketId);

            if (ticket.ResponsePausedDtm.HasValue)
            {
                ticket.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(DateTime.Now, ticket.RemainingResponseDueTime.Value.ToTimeSpan());
                ticket.ResponsePausedDtm = null;
                ticket.RemainingResponseDueTime = null;
            }
            
            if (ticket.ResolutionPausedDtm.HasValue)
            {
                ticket.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(DateTime.Now, ticket.RemainingResolutionDueTime.Value.ToTimeSpan());
                ticket.ResolutionPausedDtm = null;
                ticket.RemainingResolutionDueTime = null;
            }

            _slawareContext.SaveChanges();
        }
    }
}
