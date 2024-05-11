namespace WS_Tracking.Repository;

public class OperationCompanyRepository : BaseRepository<OperationCompanyEntity>, IOperationCompanyRepository
{
    public OperationCompanyRepository(ApplicationDbContext context) : base(context.OperationCompany)
    {

    }
}
