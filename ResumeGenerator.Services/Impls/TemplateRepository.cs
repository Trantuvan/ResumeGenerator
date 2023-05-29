using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class TemplateRepository : BaseRepository<Template>, ITemplateRepository
{
    public TemplateRepository(ResumeDbContext context) : base(context)
    {
    }
}
