namespace WS_Tracking.Hubs;

//[Authorize]
public class UsersHub : Hub<IUsersHubHelper>
{
    private readonly UserHelper _userHelper;
    public UsersHub(UserHelper userHelper)
    {
        _userHelper = userHelper;
    }
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }

    //Get All Users
    [Authorize(Policy = "ViewUsers")]
    public async Task GetAllUsers(int pageNumber = 1, int pageSize = 10)
    {
        Pagination<ApplicationUser> pagination = _userHelper.GetAllAsync();

        await Clients.All.GetAllUsers(pagination);
    }
}
