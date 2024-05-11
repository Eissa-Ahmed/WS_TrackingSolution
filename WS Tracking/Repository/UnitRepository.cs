namespace WS_Tracking.Repository;

public class UnitRepository : BaseRepository<UnitEntity>, IUnitRepository
{
    public UnitRepository(ApplicationDbContext context) : base(context.Units)
    {

    }
}

