using SLAwareApi.Entities.SLAware;

namespace SLAwareApi.Models.SLAware.TicketCategory
{
    public class TicketCategoryModels
    {

        public class TicketCategoryReturnModel
        {
            public long Id { get; set; }

            public string Name { get; set; } = null!;

            public bool IsActive { get; set; }

            public string? CreatedBy { get; set; }

            public DateTime CreatedAt { get; set; }

            public string? UpdatedBy { get; set; }

            public DateTime UpdatedAt { get; set; }

          
        }

        public class UpdateTicketCategoryRequestModel
        {
            public long Id { get; set; }

            public string Name { get; set; } = null!;

            public bool IsActive { get; set; }

            public string? CreatedBy { get; set; }

            public DateTime CreatedAt { get; set; }

            public string? UpdatedBy { get; set; }

            public DateTime UpdatedAt { get; set; }

          
        }
        public class CreateTicketCategoryRequestModel
        {
            public string Name { get; set; } = null!;

            public long loggedInUser { get; set; }

            public string? CreatedBy { get; set; }

        }


    }
}
