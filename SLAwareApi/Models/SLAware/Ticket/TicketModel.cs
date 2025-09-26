using SLAwareApi.Entities.SLAware;

namespace SLAwareApi.Models.SLAware.Ticket
{
    public class TicketModel
    {

        public class TicketReturnModel
        {
            public long Id { get; set; }

            public string TicketNumber { get; set; }

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;

            //public long TicketStatusId { get; set; }
            public string TicketStatus { get; set; }

            public long SeverityLevelId { get; set; }

            public long CreatedById { get; set; }

            public long? AssignedToId { get; set; }

            public string SubCategory { get; set; }
            public string? Category { get; set; }
            //public long SubCategoryId { get; set; }
            //public long? CategoryId { get; set; }

            public DateTime CreatedAt { get; set; }
            public bool? IsActive { get; set; }



        }
        public class UpdateTicketRequestModel
        {
            //public long Id { get; set; }

            public string TicketNumber { get; set; } = null!;

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;

            public string TicketStatus { get; set; } = null!;

            public long TicketSeverityLevelId { get; set; }
            public long loggedInUserId { get; set; }

        }

        public class CreateTicketModel
        {

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;


            public long? CategoryId { get; set; }

            public long SubCategoryId { get; set; }

            public long CreatedById { get; set; }

            //public string TicketNumber { get; set; } 
            //public long TicketStatusId { get; set; }
            //public bool? IsActive { get; set; }

            //public long SeverityLevelId { get; set; }
            //public long Id { get; set; }

            //public DateTime CreatedAt { get; set; }
            //public long? AssignedToId { get; set; }
        }


    }
}
