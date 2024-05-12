namespace WS_Tracking.WorkerService;

public class UserServices : BackgroundService
{
    private readonly UserHelper _userHelper;
    private readonly IHubContext<UsersHub> _hubUsers;
    public UserServices(UserHelper userHelper, IHubContext<UsersHub> hubUsers)
    {
        _userHelper = userHelper;
        _hubUsers = hubUsers;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        /*ApplicationUser? user = await _userHelper.GetById("8cf829f6-8e20-42cb-9c1d-adbfca75b256");
        user!.LastName = "Pro";
        await _userHelper.UpdateAsync(user);*/
        await _hubUsers.Clients.All.SendAsync("GetAllUsers", 1, 10);
        await Task.CompletedTask;
    }
}
