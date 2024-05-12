namespace WS_Tracking.Hubs;

[Authorize]
public class UsersHub : Hub<IUsersHubHelper>
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }
}
