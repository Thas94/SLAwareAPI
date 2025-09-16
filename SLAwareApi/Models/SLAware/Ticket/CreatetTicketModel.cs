using static SLAwareApi.Enums.Enums;

namespace SLAwareApi.Models.SLAware
{
    public class CreatetTicketModel
    {
        public long CreateById {  get; set; }
        public long AssignedToId {  get; set; }
        public TicketStatus TicketStatusId {  get; set; }
        //public long TicketSeverityLevelId {  get; set; }
        public long CategorylId {  get; set; }
        public long SubCategorylId {  get; set; }
        public long TagId {  get; set; }
        public string Subject {  get; set; }
        public string Description {  get; set; }
        public string Message {  get; set; }
        //public List<SlaSeverityModel> SlaSeverities { get; set; }
    }
}
