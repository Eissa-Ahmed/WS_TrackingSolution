﻿namespace WS_Tracking.Hubs;

public class OperationCompanyHub : Hub<IOperationCompanyHubHelper>
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
