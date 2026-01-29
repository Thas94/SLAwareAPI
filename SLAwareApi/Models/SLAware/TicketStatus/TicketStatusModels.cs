namespace SLAwareApi.Models.SLAware.TicketStatus
{
    public class TicketStatusModels
    {

        public class TicketStatusReturnModel
        {
            public long Id { get; set; }

            public string Name { get; set; } = null!;

            public string Description { get; set; } = null!;

            public bool Active { get; set; }

            public DateTime CreatedAt { get; set; }

            public string CreatedBy { get; set; } = null!;

            public DateTime? UpdatedAt { get; set; }

            public string? UpdatedBy { get; set; }

        }
        public class CreateTicketStatusRequestModel
        {

            public string Name { get; set; } = null!;

            public string Description { get; set; } = null!;

            public long loggedInUser { get; set; }

            public string CreatedBy { get; set; } = null!;


        }
        public class UpdateTicketStatusRequestModel
        {

            public string? Name { get; set; } = null!;

            public string? Description { get; set; } = null!;

            public bool? Active { get; set; }
            public long loggedInUser { get; set; }



        }

    }
}
