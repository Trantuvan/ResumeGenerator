using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class WorkplaceRepository : BaseRepository<Workplace>, IWorkplaceRepository
{
    public WorkplaceRepository(ResumeDbContext context) : base(context)
    {
    }
}
