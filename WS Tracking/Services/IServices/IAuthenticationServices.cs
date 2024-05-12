namespace WS_Tracking.Services.IServices;

public interface IAuthenticationServices
{
    public string? GetTokenFromRequestHeader();
    public string? GetUserIdFromToken(out string CustomerId);
}
