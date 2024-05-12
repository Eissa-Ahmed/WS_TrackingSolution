namespace WS_Tracking.WorkerService.WorkerServiceHelper;

public class UserHelper
{
    //private readonly UserManager<ApplicationUser> _userManager;
    private readonly IServiceProvider _serviceProvider;
    public UserHelper(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        //_userManager = userManager;
    }
    public async Task<ApplicationUser?> GetById(string Id)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var _userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            ApplicationUser? applicationUser = await _userManager.FindByIdAsync(Id);
            return applicationUser;
        }

    }
    public async Task UpdateAsync(ApplicationUser user)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var _userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            await _userManager.UpdateAsync(user);
        }

    }
}
