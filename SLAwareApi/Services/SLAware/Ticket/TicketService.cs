using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;

namespace SLAwareApi.Services.SLAware
{
    public class TicketService : SLAwareBaseService, ITicketService
    {
        private readonly ISlaSeverityService _slaSeverityService;
        public TicketService(ISlaSeverityService slaSeverityService, slaware_dataContext slaware_DataContext) : base(slaware_DataContext)
        { 
            _slaSeverityService = slaSeverityService;
        }

        public async Task<bool> CreateTicket(CreatetTicketModel createtTicket)
        {
            try
            {
                var tag = _slaware_DataContext.TicketTags.FirstOrDefault(x => x.Id == createtTicket.TagId);
                var severity = _slaware_DataContext.SlaSeverityLevels.FirstOrDefault(x => x.Id == tag.SlaSeverityLevelId);

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
                _slaware_DataContext.Tickets.Add(ticketModel);
                _slaware_DataContext.SaveChanges();

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
                _slaware_DataContext.TicketSlaTrackings.Add(track);
                _slaware_DataContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
