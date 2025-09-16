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


        //public async Task<bool> CreateTicket(CreatetTicketModel createtTicket)
        //{
        //    try
        //    {
        //        //Create ticket
        //        var ticketModel = new Ticket();
        //        ticketModel.Subject = createtTicket.Subject;
        //        ticketModel.Description = createtTicket.Description;
        //        ticketModel.TicketStatusId = createtTicket.TicketStatusId;
        //        ticketModel.TicketSeverityLevelId = createtTicket.TicketSeverityLevelId;
        //        ticketModel.CreatedById = createtTicket.CreateById;
        //        ticketModel.CreatedAt = DateTime.Now;
        //        ticketModel.SubCategoryId = createtTicket.SubCategorylId;
        //        _slawareContext.Tickets.Add(ticketModel);
        //        //_slaware_DataContext.SaveChanges();

        //        //Create message
        //        var messageModel = new TicketMessage();
        //        messageModel.TicketId = ticketModel.Id;
        //        messageModel.MessageContent = createtTicket.Message;
        //        messageModel.CreatedAt = DateTime.Now;
        //        _slawareContext.TicketMessages.Add(messageModel);
        //        //_slaware_DataContext.SaveChanges();

        //        //SLA tracking
        //        foreach (var sev in createtTicket.SlaSeverities)
        //        {
        //            var track = new TicketSlaTracking();
        //            track.TicketId = ticketModel.Id;
        //            track.SlaSeverityLevelId = sev.Id;
        //            track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)sev.InitialResponseHours, 0, 0));
        //            track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)sev.TargetResolutionHours, 0, 0));
        //            track.CreatedAt = DateTime.Now;
        //            _slawareContext.TicketSlaTrackings.Add(track);
        //            //_slaware_DataContext.SaveChanges();
        //        }


        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return false;
        //}



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
    }
}
