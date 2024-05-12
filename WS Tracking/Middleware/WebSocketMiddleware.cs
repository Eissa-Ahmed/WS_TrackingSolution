namespace WS_Tracking.Middleware;

public class WebSocketMiddleware
{
    private readonly RequestDelegate _requestDelegate;
    public WebSocketMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }
    // Method Invoke
    public async Task Invoke(HttpContext httpContext)
    {
        var request = httpContext.Request;

        if (request.Path.StartsWithSegments("/hubs", StringComparison.OrdinalIgnoreCase))
        {
            var accessToken = request.Query["access_token"];
            if (!string.IsNullOrEmpty(accessToken))
            {
                request.Headers.Authorization = $"Bearer {accessToken}";
            }
        }

        await _requestDelegate(httpContext);
    }
}
