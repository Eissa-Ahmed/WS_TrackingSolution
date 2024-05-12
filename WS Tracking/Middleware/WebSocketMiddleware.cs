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
        HttpRequest request = httpContext.Request;
        if (request.Path.StartsWithSegments("/hub", StringComparison.OrdinalIgnoreCase) &&
                request.Query.TryGetValue("access_token", out var accessToken))
        {
            request.Headers.Authorization = $"Bearer {accessToken}";
        }
        await _requestDelegate(httpContext);
    }
}
