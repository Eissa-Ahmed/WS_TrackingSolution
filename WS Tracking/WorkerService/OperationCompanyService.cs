namespace WS_Tracking.WorkerService;

public class OperationCompanyService : BackgroundService
{
    private readonly OperationCompanyHelper _operationCompanyHelper;
    public OperationCompanyService(OperationCompanyHelper operationCompanyHelper)
    {
        _operationCompanyHelper = operationCompanyHelper;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await _operationCompanyHelper.Changepriority();
            await Task.Delay(1000, stoppingToken);
        }
    }
}
