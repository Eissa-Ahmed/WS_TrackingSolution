namespace WS_Tracking.Hubs.HubHelper;

public interface IUsersHubHelper
{
    public Task GetAllUsers(Pagination<ApplicationUser> pagination);
}
