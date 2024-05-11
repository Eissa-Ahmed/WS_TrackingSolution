namespace WS_Tracking.WorkerService.WorkerServiceHelper;

public class OperationCompanyHelper
{
    private readonly IOperationCompanyRepository _operationCompanyRepository;
    private readonly ILogger<OperationCompanyHelper> _logger;
    public OperationCompanyHelper(ILogger<OperationCompanyHelper> logger, IOperationCompanyRepository operationCompanyRepository)
    {
        _logger = logger;
        _operationCompanyRepository = operationCompanyRepository;
    }


    public async Task Changepriority()
    {
        OperationCompanyEntity company = await _operationCompanyRepository.GetAsync(i => i.Id == "6637bc7e70747a39f14b7e00");
        company.priority = company.priority + 1;
        await _operationCompanyRepository.UpdateAsync(i => i.Id == company.Id, company);
        _logger.LogInformation("==============================");
        _logger.LogInformation("Operation Company Success Updated");
        _logger.LogInformation("==============================");
    }
}
