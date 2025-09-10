namespace SLAwareApi.Models.SLAware
{
    public class UserModel
    {
        public long UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RoleName { get; set; }
        //public Client zz { get; set; } = new Client();
        public string ClientTier { get; set; }
        public List<SlaSeverityModel> SlaSeverities { get; set; }
        public List<CommunicationTypeModel> CommunicationTypes { get; set; }
    }

    public class Client
    {
        public string Tier { get; set; }
        public List<SlaSeverityModel> SlaSeverities { get; set; }
        public List<CommunicationTypeModel> CommunicationTypes { get; set; }
    }
}
