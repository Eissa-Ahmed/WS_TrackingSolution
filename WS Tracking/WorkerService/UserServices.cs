namespace WS_Tracking.WorkerService;

public class UserServices : BackgroundService
{
    private readonly UserHelper _userHelper;
    public UserServices(UserHelper userHelper)
    {
        _userHelper = userHelper;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        ApplicationUser? user = await _userHelper.GetById("8cf829f6-8e20-42cb-9c1d-adbfca75b256");
        user!.LastName = "Pro";
        await _userHelper.UpdateAsync(user);
        await Task.CompletedTask;
    }
}
