using ResumeGenerator.Core;
using System.Linq.Expressions;

namespace ResumeGenerator.Services;

public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    public PersonRepository(ResumeDbContext context) : base(context) { }
}
