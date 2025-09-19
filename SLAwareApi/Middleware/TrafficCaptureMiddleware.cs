using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using Traffic = SLAwareApi.Entities.SLAware.Traffic;

namespace SLAwareApi.Middleware
{
    public class TrafficCaptureMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger<TrafficCaptureMiddleware> _logger;
        private readonly IServiceScopeFactory _scopeFactory;

        public TrafficCaptureMiddleware(
            RequestDelegate requestDelegate,
            ILogger<TrafficCaptureMiddleware> logger,
            IServiceScopeFactory scopeFactory)
        {
            _requestDelegate = requestDelegate;
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Capture request timestamp immediately
            DateTime requestTime = DateTime.Now;

            // Enable request body buffering
            context.Request.EnableBuffering();

            //capture request url
            string path = $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}{context.Request.QueryString}";

            //Capture the request method
            string method = context.Request.Method.ToString();

            // Capture the original body
            string requestBody = await GetRequestBody(context.Request);

            // Create a copy of the response body stream
            var originalBodyStream = context.Response.Body;
            using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            try
            {
                // Continue down the pipeline
                await _requestDelegate(context);

                // Capture response details
                //string responseContent = await GetResponseBody(context.Response);

                // Capture timestamp right after response
                DateTime responseTimestamp = DateTime.Now;

                // Create traffic record
                var traffic = new Traffic
                {
                    RequestBody = requestBody,
                    RequestIpAddress = GetClientIpAddress(context),
                    RequestTimestamp = requestTime,
                    ResponseStatusCode = context.Response.StatusCode,
                    RequestUrl = path,
                    RequestMethod = method,
                    ResponseTimestamp = responseTimestamp,
                    ExceptionType = null,
                    ExceptionMessage = null,
                    ExceptionDetail = null
                };

                // Save traffic in a separate scope
                using (var scope = _scopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<slaware_dataContext>();
                    dbContext.Traffics.Add(traffic);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log exception
                _logger.LogError(ex, "Exception occurred during request processing");

                // Create traffic record with exception details
                var traffic = new Traffic
                {
                    RequestBody = requestBody,
                    RequestIpAddress = GetClientIpAddress(context),
                    RequestTimestamp = DateTime.Now,
                    ResponseStatusCode = context.Response.StatusCode,
                    RequestUrl = path,
                    RequestMethod = method,
                    ResponseTimestamp = DateTime.Now,
                    ExceptionType = ex.GetType().ToString(),
                    ExceptionMessage = ex.Message,
                    ExceptionDetail = ex.StackTrace
                };

                // Save traffic in a separate scope
                using (var scope = _scopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<slaware_dataContext>();
                    dbContext.Traffics.Add(traffic);
                    await dbContext.SaveChangesAsync();
                }

                // Re-throw the exception
                throw;
            }

            finally
            {
                // Copy the response to the original stream
                await CopyResponseStream(responseBody, originalBodyStream);
            }
        }

        private static async Task CopyResponseStream(Stream source, Stream destination)
        {
            source.Seek(0, SeekOrigin.Begin);
            await source.CopyToAsync(destination);
        }

        private static async Task<string> GetRequestBody(HttpRequest request)
        {
            using var reader = new StreamReader(
                request.Body,
                leaveOpen: true);

            var body = await reader.ReadToEndAsync();
            request.Body.Position = 0;
            return body;
        }

        private static async Task<string> GetResponseBody(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var content = await new StreamReader(response.Body).ReadToEndAsync();
            response.Body.Seek(0, SeekOrigin.Begin);
            return content;
        }

        private static string GetClientIpAddress(HttpContext context)
        {
            string ip = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();

            if (!string.IsNullOrEmpty(ip))
            {
                // X-Forwarded-For may contain multiple IPs, take the first one
                return ip.Split(',')[0].Trim();
            }

            // Check for X-Real-IP header 
            ip = context.Request.Headers["X-Real-IP"].FirstOrDefault();
            if (!string.IsNullOrEmpty(ip))
            {
                return ip;
            }

            // Get the remote IP address
            ip = context.Connection.RemoteIpAddress?.ToString();

            // Handle localhost 
            if (ip == "::1")
            {
                return "127.0.0.1";
            }

            return ip ?? "Unknown";
        }
    }

    public static class TrafficCaptureMiddlewareExtentions
    {
        public static IApplicationBuilder UseResponseCapture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TrafficCaptureMiddleware>();
        }
    }
}
