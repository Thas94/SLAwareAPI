namespace SLAwareApi.Enums
{
    public class Enums
    {
        public enum Roles
        {
            Client = 1,
            Admin = 2,
            HelpDesk = 3,
            Agent = 4
        }

        public enum TicketStatus
        {
            New = 1,
            Assigned = 2,
            InProgress = 3,
            AwaitingFeedback = 4,
            Resolved = 5,
            Closed = 6,
        }
    }
}
