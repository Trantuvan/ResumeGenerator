using ResumeGenerator.Core;

namespace ResumeGenerator.Services;

public class AddressReposity : BaseRepository<Address>, IAddressRepository
{
    public AddressReposity(ResumeDbContext context) : base(context) { }
}
