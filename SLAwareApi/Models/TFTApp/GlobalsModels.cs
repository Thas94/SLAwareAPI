namespace SLAwareApi.Models.TFTApp
{
    public class GlobalsModels
    {
        public class ReturnModel
        {
            public bool Status { get; set; }
            public object Result { get; set; }
            public string error { get; set; }
        }


        public class ErrorTemplate
        {
            public int UserID { get; set; }
            public string ErrCallingFunction { get; set; }
            public string ErrErrorMessage { get; set; }
            public string ErrStacktrace { get; set; }
            public string JSONObject { get; set; }
        }

        public class UploadDocumentRequestModel
        {
            public long CompanyId { get; set; }
            public long UserId { get; set; }
            public long DocumentTypeId { get; set; }
            public string S3Key { get; set; } = null!;
            public string S3ObjectUrl { get; set; } = null!;
            public long loggedInUser { get; set; }
        }

    }
}
