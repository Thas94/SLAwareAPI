namespace SLAwareApi.Models.SLAware
{
    public class CommunicationTypeModel
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }

    public class MessageModel
    {
        public string created_by { get; set; }
        public string created_at { get; set; }
        public string message { get; set; }

    }
}
