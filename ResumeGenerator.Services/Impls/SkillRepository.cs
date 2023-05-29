using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class SkillRepository : BaseRepository<Skill>, ISkillRepository
{
    public SkillRepository(ResumeDbContext context) : base(context)
    {
    }
}
