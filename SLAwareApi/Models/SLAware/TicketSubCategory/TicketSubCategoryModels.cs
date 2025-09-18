using SLAwareApi.Entities.SLAware;

namespace SLAwareApi.Models.SLAware.TicketSubCategory
{
    public class TicketSubCategoryModels
    {



        public class TicketSubCategoryRequestModel
        {
            public long Id { get; set; }

            public long TicketCategoryId { get; set; }

            public long? TagId { get; set; }

            public string Name { get; set; } = null!;

            public bool IsActive { get; set; }

            public string? CreatedBy { get; set; }

            public DateTime CreatedAt { get; set; }

            public string? UpdatedBy { get; set; }

            public DateTime UpdatedAt { get; set; }


        }

        public class TicketSubCategoryReturnModel
        {
            public long Id { get; set; }

            public long TicketCategoryId { get; set; }

            public long? TagId { get; set; }

            public string Name { get; set; } = null!;

            public bool IsActive { get; set; }

            public string? CreatedBy { get; set; }

            public DateTime CreatedAt { get; set; }

            public string? UpdatedBy { get; set; }

            public DateTime UpdatedAt { get; set; }


        }

        public class UpdateTicketSubCategoryReturnModel
        {
            public long Id { get; set; }

            public long TicketCategoryId { get; set; }

            public long? TagId { get; set; }

            public string Name { get; set; } = null!;

            public bool IsActive { get; set; }

            public string? CreatedBy { get; set; }

            public DateTime CreatedAt { get; set; }

            public string? UpdatedBy { get; set; }

            public DateTime UpdatedAt { get; set; }


        }




    }
}
