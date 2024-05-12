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
    public Pagination<ApplicationUser> GetAllAsync(int pageNumber = 1, int pageSize = 10)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            int pageIndex = pageNumber - 1;

            var _userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var users = _userManager.Users.Skip(pageIndex * pageSize).Take(pageSize).ToList();

            int totalCount = users.Count;

            var paginated = new Pagination<ApplicationUser>(users, totalCount, pageIndex, pageSize);

            return paginated;
        }

    }
}
