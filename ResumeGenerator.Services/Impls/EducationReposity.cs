using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class EducationReposity : BaseRepository<Education>, IEducationRepository
{
    public EducationReposity(ResumeDbContext context) : base(context)
    {
    }
}
