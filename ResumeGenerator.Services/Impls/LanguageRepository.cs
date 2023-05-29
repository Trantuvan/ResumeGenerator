using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
{
    public LanguageRepository(ResumeDbContext context) : base(context)
    {
    }
}
