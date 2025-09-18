using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using SLAwareApi.Services.SLAware.Base;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Models.SLAware.Ticket.TicketModel;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware
{
    public class TicketService : ClinicalServiceBase, ITicketService
    {
        private readonly ISlaSeverityService _slaSeverityService;
        private readonly EntityHelper _entityHelper;

        public TicketService(EntityHelper entityHelper, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper, ISlaSeverityService slaSeverityService) : base(context, slawareContext, mapper)
        {
            _slaSeverityService = slaSeverityService;
            _entityHelper = entityHelper;

        }

        public async Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket)
        {

            ReturnModel Result = new ReturnModel();

            try
            {
                var tag = _slawareContext.TicketTags.FirstOrDefault(x => x.Id == createtTicket.TagId);
                var severity = _slawareContext.SlaSeverityLevels.FirstOrDefault(x => x.Id == tag.SlaSeverityLevelId);

                //Create ticket
                var ticketModel = new Ticket();
                ticketModel.Subject = createtTicket.Subject;
                ticketModel.Description = createtTicket.Description;
                ticketModel.TicketStatusId = (long)createtTicket.TicketStatusId;
                ticketModel.TicketSeverityLevelId = severity.Id;
                ticketModel.CreatedById = createtTicket.CreateById;
                ticketModel.CreatedAt = DateTime.Now;
                ticketModel.TicketCategoryId = createtTicket.CategoryId;
                ticketModel.ApplicationId = createtTicket.ApplicationId;
                ticketModel.TicketSubCategoryId = createtTicket.SubCategorylId;
                _slawareContext.Tickets.Add(ticketModel);
                _slawareContext.SaveChanges();

                //SLA tracking
                var track = new TicketSlaTracking();
                track.TicketId = ticketModel.Id;
                track.SlaSeverityLevelId = severity.Id;
                track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)severity.InitialReponseHours, 0, 0));
                track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)severity.TargetResolutionHours, 0, 0));
                track.CreatedAt = DateTime.Now;
                track.PausedDtm = !IsWorkingHours(ticketModel.CreatedAt) ? ticketModel.CreatedAt : null;
                track.RemainingResponseDueTime = track.PausedDtm.HasValue ? TimeOnly.FromTimeSpan(new TimeSpan((int)severity.InitialReponseHours, 0, 0)) : null;
                track.RemainingResolutionDueTime = track.PausedDtm.HasValue ? TimeOnly.FromTimeSpan(new TimeSpan((int)severity.TargetResolutionHours, 0, 0)) : null;      
                track.IsResponseSlaBreach = false;
                track.IsResolutionSlaBreach = false;
                _slawareContext.TicketSlaTrackings.Add(track);
                _slawareContext.SaveChanges();

                if (ticketModel != null)
                {
                    Result.Status = true;
                    Result.Result = ticketModel;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = ticketModel;
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
        //public async Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket)
        //{

        //    ReturnModel Result = new ReturnModel();

        //    try
        //    {
        //        var tag = _slawareContext.TicketTags.FirstOrDefault(x => x.Id == createtTicket.TagId);
        //        var severity = _slawareContext.SlaSeverityLevels.FirstOrDefault(x => x.Id == tag.SlaSeverityLevelId);

        //        //Create ticket
        //        var ticketModel = new Ticket();
        //        ticketModel.Subject = createtTicket.Subject;
        //        ticketModel.Description = createtTicket.Description;
        //        ticketModel.TicketStatusId = (long)createtTicket.TicketStatusId;
        //        ticketModel.TicketSeverityLevelId = severity.Id;
        //        ticketModel.CreatedById = createtTicket.CreateById;
        //        ticketModel.CreatedAt = DateTime.Now;
        //        ticketModel.TicketCategoryId = createtTicket.CategoryId;
        //        ticketModel.ApplicationId = createtTicket.ApplicationId;
        //        ticketModel.TicketSubCategoryId = createtTicket.SubCategorylId;
        //        _slawareContext.Tickets.Add(ticketModel);
        //        _slawareContext.SaveChanges();

        //        //SLA tracking
        //        var track = new TicketSlaTracking();
        //        track.TicketId = ticketModel.Id;
        //        track.SlaSeverityLevelId = severity.Id;
        //        //track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)severity.InitialReponseHours, 0, 0));
        //        //track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)severity.TargetResolutionHours, 0, 0));
        //        track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan(4, 0, 0)).Item1;
        //        track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan(8, 0, 0)).Item1;
        //        track.CreatedAt = DateTime.Now;
        //        track.PausedDtm = !IsWorkingHours(ticketModel.CreatedAt) ? ticketModel.CreatedAt : null;
        //        //track.RemainingResponseDueTime = track.PausedDtm.HasValue ? TimeOnly.FromTimeSpan(new TimeSpan((int)severity.InitialReponseHours, 0, 0)) : null;
        //        //track.RemainingResolutionDueTime = track.PausedDtm.HasValue ? TimeOnly.FromTimeSpan(new TimeSpan((int)severity.TargetResolutionHours, 0, 0)) : null;
                
        //        var test = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan(4, 0, 0));
        //        var test2 = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan(8, 0, 0));
        //        track.RemainingResponseDueTime = test.Item2.HasValue ? TimeOnly.FromTimeSpan(test.Item2.Value) : null;
        //        track.RemainingResolutionDueTime = test2.Item2.HasValue ? TimeOnly.FromTimeSpan(test2.Item2.Value) : null;

        //        //track.RemainingResponseDueTime = track.PausedDtm.HasValue ? TimeOnly.FromTimeSpan(track.ResponseDueDtm - track.CreatedAt) : null;
        //        //track.RemainingResolutionDueTime = track.PausedDtm.HasValue ? TimeOnly.FromTimeSpan(track.ResolutionDueDtm - track.CreatedAt) : null;
        //        track.IsResponseSlaBreach = false;
        //        track.IsResolutionSlaBreach = false;
        //        _slawareContext.TicketSlaTrackings.Add(track);
        //        _slawareContext.SaveChanges();

        //        if (ticketModel != null)
        //        {
        //            Result.Status = true;
        //            Result.Result = ticketModel;
        //            Result.error = null;
        //        }
        //        else
        //        {
        //            Result.Status = false;
        //            Result.Result = ticketModel;
        //            Result.error = "Internal server error.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Gathering All the Error Details to be saved
        //        var Err = new ErrorTemplate
        //        {
        //            ErrCallingFunction = "Ticket Service: Get Ticket List",
        //            ErrErrorMessage = ex.Message.ToString(),
        //            ErrStacktrace = ex.StackTrace.ToString(),
        //        };
        //        //await _globalService.LogError(Err);

        //    }
        //    return Result;
        //}
    }
}
