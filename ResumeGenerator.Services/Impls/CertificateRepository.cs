using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class CertificateRepository : BaseRepository<Certificate>, ICertificateRepository
{
    public CertificateRepository(ResumeDbContext context) : base(context)
    {
    }
}
