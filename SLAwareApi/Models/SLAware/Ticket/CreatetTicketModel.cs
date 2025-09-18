namespace SLAwareApi.Models.SLAware
{
    public class CreatetTicketModel
    {
        public long CreateById {  get; set; }
        public long AssignedToId {  get; set; }
        public long TicketStatusId {  get; set; }
        public long SeverityLevelId {  get; set; }
        public long SubCategorylId {  get; set; }
        public string Subject {  get; set; }
        public string Description {  get; set; }
        public string Message {  get; set; }
        public List<SlaSeverityModel> SlaSeverities { get; set; }
    }
}
