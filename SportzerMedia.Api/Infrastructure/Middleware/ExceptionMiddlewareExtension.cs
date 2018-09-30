using Microsoft.AspNetCore.Builder;

namespace SportzerMedia.Api.Infrastructure.Middleware
{
    public static class ExceptionMiddlewareExtentions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
