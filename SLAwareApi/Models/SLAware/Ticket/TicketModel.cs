using SLAwareApi.Entities.SLAware;

namespace SLAwareApi.Models.SLAware.Ticket
{
    public class TicketModel
    {



        public class TicketReturnModel
        {
            public long Id { get; set; }

            public long TicketNumber { get; set; }

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;

            public string TicketStatus { get; set; }

            public long SeverityLevelId { get; set; }

            public long CreatedById { get; set; }

            public long? AssignedToId { get; set; }

            public long SubCategoryId { get; set; }

            public DateTime CreatedAt { get; set; }
            public bool? IsActive { get; set; }



        }
        public class UpdateTicketRequestModel
        {
            public long Id { get; set; }

            public long TicketNumber { get; set; }

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;

            public string TicketStatus { get; set; }

            public long TicketSeverityLevelId { get; set; }
            public long loggedInUserId { get; set; }




        }

    }
}
