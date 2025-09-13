using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;

namespace SLAwareApi.Services.SLAware
{
    public class TicketService : SLAwareBaseService, ITicketService
    {
        public TicketService(slaware_dataContext slaware_DataContext) : base(slaware_DataContext)
        { }

        public async Task<bool> CreateTicket(CreatetTicketModel createtTicket)
        {
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
                _slaware_DataContext.Tickets.Add(ticketModel);
                //_slaware_DataContext.SaveChanges();

                //Create message
                var messageModel = new TicketMessage();
                messageModel.TicketId = ticketModel.Id;
                messageModel.MessageContent = createtTicket.Message;
                messageModel.CreatedAt = DateTime.Now;
                _slaware_DataContext.TicketMessages.Add(messageModel);
                //_slaware_DataContext.SaveChanges();

                //SLA tracking
                foreach(var sev in createtTicket.SlaSeverities)
                {
                    var track = new TicketSlaTracking();
                    track.TicketId = ticketModel.Id;
                    track.SlaSeverityLevelId = sev.Id;
                    track.ResponseDueDtm = DateTime.Now.AddHours(sev.InitialResponseHours);
                    track.ResolutionDueDtm = DateTime.Now.AddHours(sev.TargetResolutionHours);
                    track.CreatedAt = DateTime.Now;
                    _slaware_DataContext.TicketSlaTrackings.Add(track);
                    //_slaware_DataContext.SaveChanges();
                }


                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
