namespace SLAwareApi.Models.SLAware
{
    public class UserModel
    {
        public long UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RoleName { get; set; }
        public ClientModel Client { get; set; } = new ClientModel();
        public AgentModel Agent { get; set; } = new AgentModel();
    }

    public class ClientModel
    {
        public string Tier { get; set; }
        public List<SlaSeverityModel> SlaSeverities { get; set; }
        public List<CommunicationTypeModel> CommunicationTypes { get; set; }
    }

    public class AgentModel
    {
        public long Id { get; set; }
    }
}
