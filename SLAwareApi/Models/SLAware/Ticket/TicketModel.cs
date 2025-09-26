using SLAwareApi.Entities.SLAware;

namespace SLAwareApi.Models.SLAware.Ticket
{
    public class TicketModel
    {

        public class TicketReturnModel
        {
            public long Id { get; set; }

            public string TicketNumber { get; set; } = null!;
            public string TicketStatus { get; set; } = null!;

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;

            public long TicketStatusId { get; set; }

            public long SeverityLevelId { get; set; }
            public string SeverityLevel { get; set; } = null!;
            public string Category { get; set; } = null!;
            public string SubCategory { get; set; } = null!;

            public long CreatedById { get; set; }

            public long? AssignedToId { get; set; }

            public long SubCategoryId { get; set; }
            public long? CategoryId { get; set; }

            public bool? IsSlaResponseBreach { get; set; }
            public bool? IsSlaResolutionBreach { get; set; }
            public TimeOnly? RemainingResponseTime { get; set; }
            public TimeOnly? RemainingResolutionTime { get; set; }

            public DateTime CreatedAt { get; set; }
            public DateTime InitialResponseDue { get; set; }
            public DateTime TargetResolutionDue { get; set; }
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

            //public string TicketNumber { get; set; } 

            public string Subject { get; set; } = null!;

            public string Description { get; set; } = null!;

            public long TicketStatusId { get; set; }

            public long? CategoryId { get; set; }

            public long SubCategoryId { get; set; }

            public long CreatedById { get; set; }

            //public bool? IsActive { get; set; }

            //public long SeverityLevelId { get; set; }
            //public long Id { get; set; }

            //public DateTime CreatedAt { get; set; }
            //public long? AssignedToId { get; set; }
        }


    }
}
