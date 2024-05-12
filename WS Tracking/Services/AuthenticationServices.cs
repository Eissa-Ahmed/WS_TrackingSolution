namespace WS_Tracking.Services;

public class AuthenticationServices : IAuthenticationServices
{
    private readonly IOperationCompanyRepository _operationCompanyRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly JWTSettings _jwtSettings;
    public AuthenticationServices(JWTSettings jwtSettings, IOperationCompanyRepository operationCompanyRepository, IHttpContextAccessor httpContextAccessor)
    {
        _jwtSettings = jwtSettings;
        _operationCompanyRepository = operationCompanyRepository;
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetTokenFromRequestHeader()
    {
        try
        {
            if (_httpContextAccessor.HttpContext!.Request.Headers.TryGetValue("Authorization", out var authorizationHeader))
            {
                var token = authorizationHeader.ToString();
                var bearerPrefix = "Bearer ";
                if (token.StartsWith(bearerPrefix, StringComparison.OrdinalIgnoreCase))
                {
                    return token.Substring(bearerPrefix.Length);
                }
                return null;
            }
            return null;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public bool TokenIsValidate(string Token, out ClaimsPrincipal? claimsPrincipal)
    {
        try
        {
            var jwtHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _jwtSettings.Issuer,
                ValidAudience = _jwtSettings.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
                ClockSkew = TimeSpan.FromMinutes(5)
            };

            claimsPrincipal = jwtHandler.ValidateToken(Token, validationParameters, out SecurityToken securityToken);
            return true;
        }
        catch (Exception)
        {
            claimsPrincipal = null;
            return false;
        }
    }
    public string? GetUserIdFromToken(out string CustomerId)
    {
        try
        {
            CustomerId = string.Empty;
            string? token = GetTokenFromRequestHeader();
            if (token is null)
                throw new SecurityTokenException();

            bool vakidateToken = TokenIsValidate(token, out ClaimsPrincipal? claimsPrincipal);
            if (!vakidateToken)
                throw new SecurityTokenException();

            if (claimsPrincipal is null)
                return null;

            var userIdClaim = claimsPrincipal.Claims.FirstOrDefault(claim => claim.Type == "uid");
            var CustomerClaim = claimsPrincipal.Claims.FirstOrDefault(claim => claim.Type == "PCid");

            if (userIdClaim is null || CustomerClaim is null)
                return null;

            CustomerId = CustomerClaim.Value;
            var userId = userIdClaim.Value;

            return userId;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
