using static SLAwareApi.Enums.Enums;

namespace SLAwareApi.Models.SLAware
{
    public class CreatetTicketModel
    {
        public long CreateById { get; set; }
        public long AssignedToId { get; set; }
        public TicketStatus TicketStatusId { get; set; }
        public long CategoryId { get; set; }
        public long ApplicationId { get; set; }
        public long SubCategorylId { get; set; }
        public long TagId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
