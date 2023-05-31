using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeGenerator.Core;
using ResumeGenerator.Services;

namespace ResumeGenerator.API;

[ApiController]
[Route("api/[controller]")]
public class PersonalDetailController : ControllerBase
{
    #region [Fields]
    private readonly IMapper _mapper;
    private readonly IPersonRepository _personRepository;
    #endregion

    #region [Ctor]
    public PersonalDetailController(IMapper mapper, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
    }
    #endregion

    #region [Get]
    [HttpGet("{id}")]
    public async Task<ActionResult<PersonalDetailsForm>> GetById(Guid id, CancellationToken token)
    {
        var personDetail = await _personRepository
            .FindAll(p => p.Id.Equals(id))
            .Include(p => p.Addresses)
            .AsNoTracking()
            .FirstOrDefaultAsync(token);

        if (personDetail is null)
        {
            return NotFound();
        }

        return _mapper.Map<PersonalDetailsForm>(personDetail);
    }
    #endregion

    #region [Post]
    [HttpPost]
    public async Task<ActionResult> CreatePost([FromBody] PersonalDetailsForm request, CancellationToken token)
    {
        var person = _mapper.Map<Person>(request);
        _personRepository.Add(person);

        await _personRepository.SaveChangesAsync(token);

        return CreatedAtAction(nameof(GetById), new { id = person.Id }, _mapper.Map<PersonalDetailsForm>(person));
    }
    #endregion
}
